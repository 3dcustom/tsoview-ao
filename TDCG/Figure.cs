using System;
using System.Collections.Generic;
using System.Diagnostics;
//using System.Drawing;
using System.Threading;
//using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace TDCG
{
    /// <summary>
    /// フィギュア
    /// </summary>
public class Figure : IDisposable
{
    /// <summary>
    /// フィギュアが保持しているtsoリスト
    /// </summary>
    public List<TSOFile> TsoList = new List<TSOFile>();

    /// <summary>
    /// スライダ変形行列を使うか
    /// </summary>
    public static bool SliderMatrixEnabled = true;

    /// <summary>
    /// スライダ変形行列
    /// </summary>
    public SliderMatrix slider_matrix = null;

    bool clothed = false;
    /// 着衣扱いか
    public bool Clothed
    {
        get { return clothed; }
    }

    /// 着衣扱いかを算出します。
    public void ComputeClothed()
    {
        clothed = false;
        foreach (TSOFile tso in TsoList)
        {
            switch (tso.Row)
            {
                case 0x06: // 水着
                case 0x09: // 上衣
                case 0x0A: // 全衣
                    clothed = true;
                    break;
            }
        }
    }

    Vector3 center = Vector3.Empty;
    /// <summary>
    /// 中心座標
    /// </summary>
    public Vector3 Center
    {
        get { return center; }
    }

    Vector3 translation = Vector3.Empty;
    /// <summary>
    /// 移動変位
    /// </summary>
    public Vector3 Translation
    {
        get { return translation; }
    }

    TMOFile tmo = null;
    /// <summary>
    /// tmo
    /// </summary>
    public TMOFile Tmo
    {
        get { return tmo; }
        set
        {
            tmo = value;
            ResetFrameIndex();
            SetCenterToHips();
        }
    }

    /// tso nodeからtmo nodeを導出する辞書
    public Dictionary<TSONode, TMONode> nodemap;

    private MatrixStack matrixStack = null;
    private int frame_index = 0;
    private int current_frame_index = 0;

    /// <summary>
    /// フィギュアを生成します。
    /// </summary>
    public Figure()
    {
        if (SliderMatrixEnabled)
            slider_matrix = new SliderMatrix();
        tmo = new TMOFile();
        nodemap = new Dictionary<TSONode, TMONode>();
        matrixStack = new MatrixStack();

        LightDirection = new Vector3(0.0f, 0.0f, -1.0f);
    }

    /// <summary>
    /// フィギュアを移動します（相対座標）。
    /// </summary>
    /// <param name="dx">X軸変位</param>
    /// <param name="dy">Y軸変位</param>
    /// <param name="dz">Z軸変位</param>
    public void Move(float dx, float dy, float dz)
    {
        Move(new Vector3(dx, dy, dz));
    }

    /// <summary>
    /// フィギュアを移動します（相対座標）。
    /// </summary>
    /// <param name="delta">変位</param>
    public void Move(Vector3 delta)
    {
        translation += delta;
        UpdateBoneMatrices(true);
    }

    /// <summary>
    /// 指定位置にあるtsoの位置を入れ替えます。描画順を変更します。
    /// </summary>
    /// <param name="aidx">リスト上の位置a</param>
    /// <param name="bidx">リスト上の位置b</param>
    public void SwapAt(int aidx, int bidx)
    {
        Debug.Assert(aidx < bidx);
        TSOFile a = TsoList[aidx];
        TSOFile b = TsoList[bidx];
        TsoList.RemoveAt(bidx);
        TsoList.RemoveAt(aidx);
        TsoList.Insert(aidx, b);
        TsoList.Insert(bidx, a);
    }

    /// <summary>
    /// nodemapとbone行列を更新します。
    /// tmoが読み込まれていない場合は先頭のtsoからtmoを生成します。
    /// </summary>
    public void UpdateNodeMapAndBoneMatrices()
    {
        if (tmo.frames == null)
            RegenerateTmo();

        UpdateNodeMap();

        UpdateBoneMatrices(true);
    }

    /// <summary>
    /// 先頭のtsoからtmoを生成します。
    /// </summary>
    public void RegenerateTmo()
    {
        if (TsoList.Count != 0)
        {
            Tmo = TsoList[0].GenerateTmo();
        }
    }

    /// <summary>
    /// nodemapを更新します。
    /// </summary>
    public void UpdateNodeMap()
    {
        nodemap.Clear();
        if (tmo.frames != null)
        foreach (TSOFile tso in TsoList)
            AddNodeMap(tso);
    }

    /// <summary>
    /// tsoに対するnodemapを追加します。
    /// </summary>
    /// <param name="tso">tso</param>
    protected void AddNodeMap(TSOFile tso)
    {
        foreach (TSONode tso_node in tso.nodes)
        {
            TMONode tmo_node;
            if (tmo.nodemap.TryGetValue(tso_node.Path, out tmo_node))
                nodemap.Add(tso_node, tmo_node);
        }
    }

    /// <summary>
    /// フレーム番号を0に設定します。
    /// </summary>
    protected void ResetFrameIndex()
    {
        frame_index = 0;
        current_frame_index = 0;
    }

    /// <summary>
    /// 中心点を腰boneの位置に設定します。
    /// </summary>
    protected void SetCenterToHips()
    {
        if (tmo.frames == null)
            return;

        TMONode tmo_node;
        if (tmo.nodemap.TryGetValue("|W_Hips", out tmo_node))
        {
            Debug.Assert(tmo_node.matrices.Count > 0);
            Matrix m = tmo_node.matrices[0].m;
            center = new Vector3(m.M41, m.M42, m.M43);
        }
    }

    /// <summary>
    /// 次のフレームに進みます。
    /// </summary>
    public void NextTMOFrame()
    {
        if (tmo.frames != null)
        {
            frame_index++;
            if (frame_index >= tmo.frames.Length)
                frame_index = 0;
        }
    }

    /// <summary>
    /// 現在のフレームを得ます。
    /// </summary>
    /// <returns>現在のtmo frame</returns>
    protected TMOFrame GetTMOFrame()
    {
        if (tmo.frames != null)
        {
            Debug.Assert(current_frame_index >= 0 && current_frame_index < tmo.frames.Length);
            return tmo.frames[current_frame_index];
        }
        return null;
    }

    /// <summary>
    /// 現在のフレーム番号を得ます。
    /// </summary>
    /// <returns></returns>
    public int GetFrameIndex()
    {
        return current_frame_index;
    }

    /// <summary>
    /// bone行列を更新します。
    /// ただしtmo frameを無視します。
    /// </summary>
    public void UpdateBoneMatricesWithoutTMOFrame()
    {
        UpdateBoneMatrices(tmo, null);
    }

    /// <summary>
    /// bone行列更新時に呼び出されるハンドラ
    /// </summary>
    public event EventHandler UpdateBoneMatricesEvent;

    /// <summary>
    /// bone行列を更新します。
    /// </summary>
    /// <param name="forced">falseの場合frame indexに変更なければ更新しません。</param>
    public void UpdateBoneMatrices(bool forced = false)
    {
        if (!forced && frame_index == current_frame_index)
            return;
        current_frame_index = frame_index;

        TMOFrame tmo_frame = GetTMOFrame();

        UpdateBoneMatrices(tmo, tmo_frame);

        if (UpdateBoneMatricesEvent != null)
            UpdateBoneMatricesEvent(this, EventArgs.Empty);
    }
    
    /// <summary>
    /// bone行列を更新します。
    /// </summary>
    protected void UpdateBoneMatrices(TMOFile tmo, TMOFrame tmo_frame)
    {
        if (tmo.nodes == null)
            return;

        if (tmo.w_hips_node != null)
        {
            matrixStack.LoadIdentity();
            UpdateBoneMatrices(tmo.w_hips_node, tmo_frame);
        }
        foreach (TMONode tmo_node in tmo.root_nodes_except_w_hips)
        {
            matrixStack.LoadIdentity();
            UpdateBoneMatricesWithoutSlider(tmo_node, tmo_frame);
        }
    }

    static Regex re_chichi = new Regex(@"\AChichi");

    /// <summary>
    /// bone行列を更新します。
    /// </summary>
    protected void UpdateBoneMatrices(TMONode tmo_node, TMOFrame tmo_frame)
    {
        matrixStack.Push();

        if (tmo_frame != null)
        {
            // tmo animation
            tmo_node.TransformationMatrix = tmo_frame.matrices[tmo_node.Id].m;
        }
        Matrix m = tmo_node.TransformationMatrix;

        if (slider_matrix != null)
        {
            bool chichi_p = re_chichi.IsMatch(tmo_node.Name);

            if (chichi_p)
            {
                slider_matrix.ScaleChichi(tmo_node, ref m);

                if (slider_matrix.Flat())
                {
                    if (clothed)
                        slider_matrix.TransformChichiFlatClothed(tmo_node, ref m);
                    else
                        slider_matrix.TransformChichiFlat(tmo_node, ref m);
                }
            }
            else
                slider_matrix.TransformFace(tmo_node, ref m);

            matrixStack.MultiplyMatrixLocal(m);
            m = matrixStack.Top;

            if (! chichi_p)
                slider_matrix.Scale(tmo_node, ref m);
        }
        else
        {
            matrixStack.MultiplyMatrixLocal(m);
            m = matrixStack.Top;
        }

        tmo_node.combined_matrix = m;

        foreach (TMONode child_node in tmo_node.children)
            UpdateBoneMatrices(child_node, tmo_frame);

        matrixStack.Pop();
    }

    /// <summary>
    /// bone行列を更新します（体型変更なし）。
    /// </summary>
    /// <param name="forced">falseの場合frame indexに変更なければ更新しません。</param>
    public void UpdateBoneMatricesWithoutSlider(bool forced = false)
    {
        if (!forced && frame_index == current_frame_index)
            return;
        current_frame_index = frame_index;

        TMOFrame tmo_frame = GetTMOFrame();

        UpdateBoneMatricesWithoutSlider(tmo, tmo_frame);
    }
    
    /// <summary>
    /// bone行列を更新します（体型変更なし）。
    /// </summary>
    protected void UpdateBoneMatricesWithoutSlider(TMOFile tmo, TMOFrame tmo_frame)
    {
        if (tmo.nodes == null)
            return;

        if (tmo.w_hips_node != null)
        {
            matrixStack.LoadIdentity();
            UpdateBoneMatricesWithoutSlider(tmo.w_hips_node, tmo_frame);
        }
        foreach (TMONode tmo_node in tmo.root_nodes_except_w_hips)
        {
            matrixStack.LoadIdentity();
            UpdateBoneMatricesWithoutSlider(tmo_node, tmo_frame);
        }
    }

    /// <summary>
    /// bone行列を更新します（体型変更なし）。
    /// </summary>
    protected void UpdateBoneMatricesWithoutSlider(TMONode tmo_node, TMOFrame tmo_frame)
    {
        matrixStack.Push();

        if (tmo_frame != null)
        {
            // tmo animation
            tmo_node.TransformationMatrix = tmo_frame.matrices[tmo_node.Id].m;
        }
        Matrix m = tmo_node.TransformationMatrix;

        matrixStack.MultiplyMatrixLocal(m);
        m = matrixStack.Top;

        tmo_node.combined_matrix = m;

        foreach (TMONode child_node in tmo_node.children)
            UpdateBoneMatricesWithoutSlider(child_node, tmo_frame);

        matrixStack.Pop();
    }

    /// <summary>
    /// TSOFileを指定device上で開きます。
    /// </summary>
    /// <param name="device">device</param>
    /// <param name="effect">effect</param>
    public void OpenTSOFile(Device device, Effect effect)
    {
        foreach (TSOFile tso in TsoList)
            tso.Open(device, effect);
    }

    /// <summary>
    /// 指定モーションフレームに進みます。
    /// </summary>
    public void SetFrameIndex(int frame_index)
    {
        Debug.Assert(frame_index >= 0);
        if (tmo.frames != null)
        {
            if (frame_index >= tmo.frames.Length)
                this.frame_index = 0;
            else
                this.frame_index = frame_index;
        }
    }

    /// <summary>
    /// スキン変形行列の配列を得ます。
    /// </summary>
    /// <param name="sub_mesh">サブメッシュ</param>
    /// <returns>スキン変形行列の配列</returns>
    public Matrix[] ClipBoneMatrices(TSOSubMesh sub_mesh)
    {
        Matrix[] clipped_boneMatrices = new Matrix[sub_mesh.maxPalettes];

        for (int numPalettes = 0; numPalettes < sub_mesh.maxPalettes; numPalettes++)
        {
            TSONode tso_node = sub_mesh.GetBone(numPalettes);
            TMONode tmo_node;
            if (nodemap.TryGetValue(tso_node, out tmo_node))
                clipped_boneMatrices[numPalettes] = tso_node.offset_matrix * tmo_node.combined_matrix;
        }
        return clipped_boneMatrices;
    }

    /// <summary>
    /// 光源方向
    /// </summary>
    public Vector3 LightDirection { get; set; }

    /// <summary>
    /// 光源方向ベクトルを得ます。
    /// </summary>
    /// <returns></returns>
    public Vector4 LightDirForced()
    {
        return new Vector4(LightDirection.X, LightDirection.Y, LightDirection.Z, 0.0f);
    }

    /// <summary>
    /// 内部objectを破棄します。
    /// </summary>
    public void Dispose()
    {
        foreach (TSOFile tso in TsoList)
            tso.Dispose();
    }
}
}
