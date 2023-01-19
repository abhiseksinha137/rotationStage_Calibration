namespace rotationStage_Calibration
{
    partial class Form1
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
            this.btnStartCam = new System.Windows.Forms.Button();
            this.picBx1 = new System.Windows.Forms.PictureBox();
            this.chkBxFlip = new System.Windows.Forms.CheckBox();
            this.btnStopCam = new System.Windows.Forms.Button();
            this.picBx2 = new System.Windows.Forms.PictureBox();
            this.btnCapure = new System.Windows.Forms.Button();
            this.cmbbxCamNum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartCam
            // 
            this.btnStartCam.Location = new System.Drawing.Point(151, 11);
            this.btnStartCam.Name = "btnStartCam";
            this.btnStartCam.Size = new System.Drawing.Size(75, 23);
            this.btnStartCam.TabIndex = 0;
            this.btnStartCam.Text = "Start Cam";
            this.btnStartCam.UseVisualStyleBackColor = true;
            this.btnStartCam.Click += new System.EventHandler(this.btnStartCam_Click);
            // 
            // picBx1
            // 
            this.picBx1.Location = new System.Drawing.Point(2, 58);
            this.picBx1.Name = "picBx1";
            this.picBx1.Size = new System.Drawing.Size(416, 376);
            this.picBx1.TabIndex = 1;
            this.picBx1.TabStop = false;
            // 
            // chkBxFlip
            // 
            this.chkBxFlip.AutoSize = true;
            this.chkBxFlip.Location = new System.Drawing.Point(313, 16);
            this.chkBxFlip.Name = "chkBxFlip";
            this.chkBxFlip.Size = new System.Drawing.Size(92, 17);
            this.chkBxFlip.TabIndex = 2;
            this.chkBxFlip.Text = "Flip Horizontal";
            this.chkBxFlip.UseVisualStyleBackColor = true;
            // 
            // btnStopCam
            // 
            this.btnStopCam.Location = new System.Drawing.Point(232, 11);
            this.btnStopCam.Name = "btnStopCam";
            this.btnStopCam.Size = new System.Drawing.Size(75, 23);
            this.btnStopCam.TabIndex = 0;
            this.btnStopCam.Text = "Stop Cam";
            this.btnStopCam.UseVisualStyleBackColor = true;
            this.btnStopCam.Click += new System.EventHandler(this.btnStopCam_Click);
            // 
            // picBx2
            // 
            this.picBx2.Location = new System.Drawing.Point(424, 58);
            this.picBx2.Name = "picBx2";
            this.picBx2.Size = new System.Drawing.Size(417, 376);
            this.picBx2.TabIndex = 1;
            this.picBx2.TabStop = false;
            // 
            // btnCapure
            // 
            this.btnCapure.Location = new System.Drawing.Point(424, 10);
            this.btnCapure.Name = "btnCapure";
            this.btnCapure.Size = new System.Drawing.Size(106, 23);
            this.btnCapure.TabIndex = 3;
            this.btnCapure.Text = "Capture Reference";
            this.btnCapure.UseVisualStyleBackColor = true;
            this.btnCapure.Click += new System.EventHandler(this.btnCapure_Click);
            // 
            // cmbbxCamNum
            // 
            this.cmbbxCamNum.FormattingEnabled = true;
            this.cmbbxCamNum.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cmbbxCamNum.Location = new System.Drawing.Point(89, 12);
            this.cmbbxCamNum.Name = "cmbbxCamNum";
            this.cmbbxCamNum.Size = new System.Drawing.Size(56, 21);
            this.cmbbxCamNum.TabIndex = 4;
            this.cmbbxCamNum.SelectedIndexChanged += new System.EventHandler(this.cmbbxCamNum_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Camera Num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Camera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Overlay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 439);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbbxCamNum);
            this.Controls.Add(this.btnCapure);
            this.Controls.Add(this.chkBxFlip);
            this.Controls.Add(this.picBx2);
            this.Controls.Add(this.picBx1);
            this.Controls.Add(this.btnStopCam);
            this.Controls.Add(this.btnStartCam);
            this.Name = "Form1";
            this.Text = "Rotation Stage Calibration";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartCam;
        private System.Windows.Forms.PictureBox picBx1;
        private System.Windows.Forms.CheckBox chkBxFlip;
        private System.Windows.Forms.Button btnStopCam;
        private System.Windows.Forms.PictureBox picBx2;
        private System.Windows.Forms.Button btnCapure;
        private System.Windows.Forms.ComboBox cmbbxCamNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

