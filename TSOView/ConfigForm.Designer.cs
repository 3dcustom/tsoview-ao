﻿namespace TSOView
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDepthMap = new System.Windows.Forms.GroupBox();
            this.tbzfarPlane = new System.Windows.Forms.TextBox();
            this.lbzfarPlane = new System.Windows.Forms.Label();
            this.tbznearPlane = new System.Windows.Forms.TextBox();
            this.lbznearPlane = new System.Windows.Forms.Label();
            this.gbAmbientOcclusion = new System.Windows.Forms.GroupBox();
            this.edAORadius = new System.Windows.Forms.TextBox();
            this.edAOIntensity = new System.Windows.Forms.TextBox();
            this.tbAORadius = new System.Windows.Forms.TrackBar();
            this.lbAORadius = new System.Windows.Forms.Label();
            this.tbAOIntensity = new System.Windows.Forms.TrackBar();
            this.lbAOIntensity = new System.Windows.Forms.Label();
            this.gbDiffusion = new System.Windows.Forms.GroupBox();
            this.edDFExtent = new System.Windows.Forms.TextBox();
            this.edDFIntensity = new System.Windows.Forms.TextBox();
            this.tbDFExtent = new System.Windows.Forms.TrackBar();
            this.lbDFExtent = new System.Windows.Forms.Label();
            this.tbDFIntensity = new System.Windows.Forms.TrackBar();
            this.lbDFIntensity = new System.Windows.Forms.Label();
            this.gbCamera = new System.Windows.Forms.GroupBox();
            this.edRoll = new System.Windows.Forms.TextBox();
            this.edFovy = new System.Windows.Forms.TextBox();
            this.cbInverse = new System.Windows.Forms.CheckBox();
            this.tbRoll = new System.Windows.Forms.TrackBar();
            this.lbRoll = new System.Windows.Forms.Label();
            this.tbFovy = new System.Windows.Forms.TrackBar();
            this.lbFovy = new System.Windows.Forms.Label();
            this.gbDepthMap.SuspendLayout();
            this.gbAmbientOcclusion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAORadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAOIntensity)).BeginInit();
            this.gbDiffusion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDFExtent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDFIntensity)).BeginInit();
            this.gbCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFovy)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDepthMap
            // 
            this.gbDepthMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDepthMap.Controls.Add(this.tbzfarPlane);
            this.gbDepthMap.Controls.Add(this.lbzfarPlane);
            this.gbDepthMap.Controls.Add(this.tbznearPlane);
            this.gbDepthMap.Controls.Add(this.lbznearPlane);
            this.gbDepthMap.Location = new System.Drawing.Point(12, 130);
            this.gbDepthMap.Name = "gbDepthMap";
            this.gbDepthMap.Size = new System.Drawing.Size(260, 65);
            this.gbDepthMap.TabIndex = 1;
            this.gbDepthMap.TabStop = false;
            this.gbDepthMap.Text = "Depth map";
            // 
            // tbzfarPlane
            // 
            this.tbzfarPlane.Location = new System.Drawing.Point(105, 37);
            this.tbzfarPlane.Name = "tbzfarPlane";
            this.tbzfarPlane.Size = new System.Drawing.Size(50, 19);
            this.tbzfarPlane.TabIndex = 3;
            this.tbzfarPlane.Text = "50";
            this.tbzfarPlane.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbzfarPlane.TextChanged += new System.EventHandler(this.tbzfarPlane_TextChanged);
            // 
            // lbzfarPlane
            // 
            this.lbzfarPlane.AutoSize = true;
            this.lbzfarPlane.Location = new System.Drawing.Point(26, 40);
            this.lbzfarPlane.Name = "lbzfarPlane";
            this.lbzfarPlane.Size = new System.Drawing.Size(55, 12);
            this.lbzfarPlane.TabIndex = 2;
            this.lbzfarPlane.Text = "zfar plane";
            // 
            // tbznearPlane
            // 
            this.tbznearPlane.Location = new System.Drawing.Point(105, 12);
            this.tbznearPlane.Name = "tbznearPlane";
            this.tbznearPlane.Size = new System.Drawing.Size(50, 19);
            this.tbznearPlane.TabIndex = 1;
            this.tbznearPlane.Text = "15";
            this.tbznearPlane.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbznearPlane.TextChanged += new System.EventHandler(this.tbznearPlane_TextChanged);
            // 
            // lbznearPlane
            // 
            this.lbznearPlane.AutoSize = true;
            this.lbznearPlane.Location = new System.Drawing.Point(26, 15);
            this.lbznearPlane.Name = "lbznearPlane";
            this.lbznearPlane.Size = new System.Drawing.Size(63, 12);
            this.lbznearPlane.TabIndex = 0;
            this.lbznearPlane.Text = "znear plane";
            // 
            // gbAmbientOcclusion
            // 
            this.gbAmbientOcclusion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAmbientOcclusion.Controls.Add(this.edAORadius);
            this.gbAmbientOcclusion.Controls.Add(this.edAOIntensity);
            this.gbAmbientOcclusion.Controls.Add(this.tbAORadius);
            this.gbAmbientOcclusion.Controls.Add(this.lbAORadius);
            this.gbAmbientOcclusion.Controls.Add(this.tbAOIntensity);
            this.gbAmbientOcclusion.Controls.Add(this.lbAOIntensity);
            this.gbAmbientOcclusion.Location = new System.Drawing.Point(12, 201);
            this.gbAmbientOcclusion.Name = "gbAmbientOcclusion";
            this.gbAmbientOcclusion.Size = new System.Drawing.Size(260, 95);
            this.gbAmbientOcclusion.TabIndex = 2;
            this.gbAmbientOcclusion.TabStop = false;
            this.gbAmbientOcclusion.Text = "Ambient Occlusion";
            // 
            // edAORadius
            // 
            this.edAORadius.Location = new System.Drawing.Point(219, 54);
            this.edAORadius.Name = "edAORadius";
            this.edAORadius.ReadOnly = true;
            this.edAORadius.Size = new System.Drawing.Size(35, 19);
            this.edAORadius.TabIndex = 5;
            this.edAORadius.Text = "2.50";
            this.edAORadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edAOIntensity
            // 
            this.edAOIntensity.Location = new System.Drawing.Point(219, 18);
            this.edAOIntensity.Name = "edAOIntensity";
            this.edAOIntensity.ReadOnly = true;
            this.edAOIntensity.Size = new System.Drawing.Size(35, 19);
            this.edAOIntensity.TabIndex = 2;
            this.edAOIntensity.Text = "0.50";
            this.edAOIntensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbAORadius
            // 
            this.tbAORadius.AutoSize = false;
            this.tbAORadius.Location = new System.Drawing.Point(61, 54);
            this.tbAORadius.Maximum = 20;
            this.tbAORadius.Name = "tbAORadius";
            this.tbAORadius.Size = new System.Drawing.Size(152, 30);
            this.tbAORadius.TabIndex = 4;
            this.tbAORadius.Value = 10;
            this.tbAORadius.ValueChanged += new System.EventHandler(this.tbAORadius_ValueChanged);
            // 
            // lbAORadius
            // 
            this.lbAORadius.AutoSize = true;
            this.lbAORadius.Location = new System.Drawing.Point(6, 54);
            this.lbAORadius.Name = "lbAORadius";
            this.lbAORadius.Size = new System.Drawing.Size(36, 12);
            this.lbAORadius.TabIndex = 3;
            this.lbAORadius.Text = "radius";
            // 
            // tbAOIntensity
            // 
            this.tbAOIntensity.AutoSize = false;
            this.tbAOIntensity.Location = new System.Drawing.Point(61, 18);
            this.tbAOIntensity.Maximum = 20;
            this.tbAOIntensity.Name = "tbAOIntensity";
            this.tbAOIntensity.Size = new System.Drawing.Size(152, 30);
            this.tbAOIntensity.TabIndex = 1;
            this.tbAOIntensity.Value = 10;
            this.tbAOIntensity.ValueChanged += new System.EventHandler(this.tbAOIntensity_ValueChanged);
            // 
            // lbAOIntensity
            // 
            this.lbAOIntensity.AutoSize = true;
            this.lbAOIntensity.Location = new System.Drawing.Point(6, 18);
            this.lbAOIntensity.Name = "lbAOIntensity";
            this.lbAOIntensity.Size = new System.Drawing.Size(49, 12);
            this.lbAOIntensity.TabIndex = 0;
            this.lbAOIntensity.Text = "intensity";
            // 
            // gbDiffusion
            // 
            this.gbDiffusion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDiffusion.Controls.Add(this.edDFExtent);
            this.gbDiffusion.Controls.Add(this.edDFIntensity);
            this.gbDiffusion.Controls.Add(this.tbDFExtent);
            this.gbDiffusion.Controls.Add(this.lbDFExtent);
            this.gbDiffusion.Controls.Add(this.tbDFIntensity);
            this.gbDiffusion.Controls.Add(this.lbDFIntensity);
            this.gbDiffusion.Location = new System.Drawing.Point(12, 302);
            this.gbDiffusion.Name = "gbDiffusion";
            this.gbDiffusion.Size = new System.Drawing.Size(260, 95);
            this.gbDiffusion.TabIndex = 3;
            this.gbDiffusion.TabStop = false;
            this.gbDiffusion.Text = "Diffusion";
            // 
            // edDFExtent
            // 
            this.edDFExtent.Location = new System.Drawing.Point(219, 54);
            this.edDFExtent.Name = "edDFExtent";
            this.edDFExtent.ReadOnly = true;
            this.edDFExtent.Size = new System.Drawing.Size(35, 19);
            this.edDFExtent.TabIndex = 5;
            this.edDFExtent.Text = "2.00";
            this.edDFExtent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edDFIntensity
            // 
            this.edDFIntensity.Location = new System.Drawing.Point(219, 18);
            this.edDFIntensity.Name = "edDFIntensity";
            this.edDFIntensity.ReadOnly = true;
            this.edDFIntensity.Size = new System.Drawing.Size(35, 19);
            this.edDFIntensity.TabIndex = 2;
            this.edDFIntensity.Text = "0.50";
            this.edDFIntensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbDFExtent
            // 
            this.tbDFExtent.AutoSize = false;
            this.tbDFExtent.Location = new System.Drawing.Point(61, 54);
            this.tbDFExtent.Maximum = 30;
            this.tbDFExtent.Minimum = 10;
            this.tbDFExtent.Name = "tbDFExtent";
            this.tbDFExtent.Size = new System.Drawing.Size(152, 30);
            this.tbDFExtent.TabIndex = 4;
            this.tbDFExtent.Value = 20;
            this.tbDFExtent.ValueChanged += new System.EventHandler(this.tbDFExtent_ValueChanged);
            // 
            // lbDFExtent
            // 
            this.lbDFExtent.AutoSize = true;
            this.lbDFExtent.Location = new System.Drawing.Point(6, 54);
            this.lbDFExtent.Name = "lbDFExtent";
            this.lbDFExtent.Size = new System.Drawing.Size(37, 12);
            this.lbDFExtent.TabIndex = 3;
            this.lbDFExtent.Text = "extent";
            // 
            // tbDFIntensity
            // 
            this.tbDFIntensity.AutoSize = false;
            this.tbDFIntensity.Location = new System.Drawing.Point(61, 18);
            this.tbDFIntensity.Maximum = 20;
            this.tbDFIntensity.Name = "tbDFIntensity";
            this.tbDFIntensity.Size = new System.Drawing.Size(152, 30);
            this.tbDFIntensity.TabIndex = 1;
            this.tbDFIntensity.Value = 10;
            this.tbDFIntensity.ValueChanged += new System.EventHandler(this.tbDFIntensity_ValueChanged);
            // 
            // lbDFIntensity
            // 
            this.lbDFIntensity.AutoSize = true;
            this.lbDFIntensity.Location = new System.Drawing.Point(6, 18);
            this.lbDFIntensity.Name = "lbDFIntensity";
            this.lbDFIntensity.Size = new System.Drawing.Size(49, 12);
            this.lbDFIntensity.TabIndex = 0;
            this.lbDFIntensity.Text = "intensity";
            // 
            // gbCamera
            // 
            this.gbCamera.Controls.Add(this.edRoll);
            this.gbCamera.Controls.Add(this.edFovy);
            this.gbCamera.Controls.Add(this.cbInverse);
            this.gbCamera.Controls.Add(this.tbRoll);
            this.gbCamera.Controls.Add(this.lbRoll);
            this.gbCamera.Controls.Add(this.tbFovy);
            this.gbCamera.Controls.Add(this.lbFovy);
            this.gbCamera.Location = new System.Drawing.Point(12, 12);
            this.gbCamera.Name = "gbCamera";
            this.gbCamera.Size = new System.Drawing.Size(260, 112);
            this.gbCamera.TabIndex = 0;
            this.gbCamera.TabStop = false;
            this.gbCamera.Text = "Camera";
            // 
            // edRoll
            // 
            this.edRoll.Location = new System.Drawing.Point(219, 54);
            this.edRoll.Name = "edRoll";
            this.edRoll.ReadOnly = true;
            this.edRoll.Size = new System.Drawing.Size(35, 19);
            this.edRoll.TabIndex = 5;
            this.edRoll.Text = "0";
            this.edRoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edFovy
            // 
            this.edFovy.Location = new System.Drawing.Point(219, 18);
            this.edFovy.Name = "edFovy";
            this.edFovy.ReadOnly = true;
            this.edFovy.Size = new System.Drawing.Size(35, 19);
            this.edFovy.TabIndex = 2;
            this.edFovy.Text = "30";
            this.edFovy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbInverse
            // 
            this.cbInverse.AutoSize = true;
            this.cbInverse.Location = new System.Drawing.Point(26, 90);
            this.cbInverse.Name = "cbInverse";
            this.cbInverse.Size = new System.Drawing.Size(104, 16);
            this.cbInverse.TabIndex = 6;
            this.cbInverse.Text = "inverse rotation";
            this.cbInverse.UseVisualStyleBackColor = true;
            this.cbInverse.CheckedChanged += new System.EventHandler(this.cbInverse_CheckedChanged);
            // 
            // tbRoll
            // 
            this.tbRoll.AutoSize = false;
            this.tbRoll.LargeChange = 3;
            this.tbRoll.Location = new System.Drawing.Point(61, 54);
            this.tbRoll.Maximum = 18;
            this.tbRoll.Name = "tbRoll";
            this.tbRoll.Size = new System.Drawing.Size(152, 30);
            this.tbRoll.TabIndex = 4;
            this.tbRoll.ValueChanged += new System.EventHandler(this.tbRoll_ValueChanged);
            // 
            // lbRoll
            // 
            this.lbRoll.AutoSize = true;
            this.lbRoll.Location = new System.Drawing.Point(6, 54);
            this.lbRoll.Name = "lbRoll";
            this.lbRoll.Size = new System.Drawing.Size(21, 12);
            this.lbRoll.TabIndex = 3;
            this.lbRoll.Text = "roll";
            // 
            // tbFovy
            // 
            this.tbFovy.AutoSize = false;
            this.tbFovy.LargeChange = 3;
            this.tbFovy.Location = new System.Drawing.Point(61, 18);
            this.tbFovy.Maximum = 18;
            this.tbFovy.Name = "tbFovy";
            this.tbFovy.Size = new System.Drawing.Size(152, 30);
            this.tbFovy.TabIndex = 1;
            this.tbFovy.Value = 3;
            this.tbFovy.ValueChanged += new System.EventHandler(this.tbFovy_ValueChanged);
            // 
            // lbFovy
            // 
            this.lbFovy.AutoSize = true;
            this.lbFovy.Location = new System.Drawing.Point(6, 18);
            this.lbFovy.Name = "lbFovy";
            this.lbFovy.Size = new System.Drawing.Size(44, 12);
            this.lbFovy.TabIndex = 0;
            this.lbFovy.Text = "fov in y";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.gbCamera);
            this.Controls.Add(this.gbDiffusion);
            this.Controls.Add(this.gbAmbientOcclusion);
            this.Controls.Add(this.gbDepthMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConfigForm";
            this.Text = "AO Config";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigForm_FormClosing);
            this.gbDepthMap.ResumeLayout(false);
            this.gbDepthMap.PerformLayout();
            this.gbAmbientOcclusion.ResumeLayout(false);
            this.gbAmbientOcclusion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAORadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAOIntensity)).EndInit();
            this.gbDiffusion.ResumeLayout(false);
            this.gbDiffusion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDFExtent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDFIntensity)).EndInit();
            this.gbCamera.ResumeLayout(false);
            this.gbCamera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFovy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDepthMap;
        private System.Windows.Forms.GroupBox gbAmbientOcclusion;
        private System.Windows.Forms.TextBox tbzfarPlane;
        private System.Windows.Forms.Label lbzfarPlane;
        private System.Windows.Forms.TextBox tbznearPlane;
        private System.Windows.Forms.Label lbznearPlane;
        private System.Windows.Forms.TrackBar tbAORadius;
        private System.Windows.Forms.Label lbAORadius;
        private System.Windows.Forms.TrackBar tbAOIntensity;
        private System.Windows.Forms.Label lbAOIntensity;
        private System.Windows.Forms.GroupBox gbDiffusion;
        private System.Windows.Forms.TrackBar tbDFIntensity;
        private System.Windows.Forms.Label lbDFIntensity;
        private System.Windows.Forms.TrackBar tbDFExtent;
        private System.Windows.Forms.Label lbDFExtent;
        private System.Windows.Forms.TextBox edAORadius;
        private System.Windows.Forms.TextBox edAOIntensity;
        private System.Windows.Forms.TextBox edDFExtent;
        private System.Windows.Forms.TextBox edDFIntensity;
        private System.Windows.Forms.GroupBox gbCamera;
        private System.Windows.Forms.TextBox edRoll;
        private System.Windows.Forms.TextBox edFovy;
        private System.Windows.Forms.CheckBox cbInverse;
        private System.Windows.Forms.TrackBar tbRoll;
        private System.Windows.Forms.Label lbRoll;
        private System.Windows.Forms.TrackBar tbFovy;
        private System.Windows.Forms.Label lbFovy;
    }
}
