namespace EmRjt
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.btnOk = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_ver = new System.Windows.Forms.Label();
            this.lbl_copy = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(222, 85);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::EmRjt.Properties.Resources.rarjpegpic;
            this.pic_logo.Location = new System.Drawing.Point(12, 12);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(96, 96);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_logo.TabIndex = 1;
            this.pic_logo.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_title.Location = new System.Drawing.Point(114, 12);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(49, 16);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "<title>";
            // 
            // lbl_ver
            // 
            this.lbl_ver.AutoSize = true;
            this.lbl_ver.Location = new System.Drawing.Point(114, 90);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(53, 13);
            this.lbl_ver.TabIndex = 3;
            this.lbl_ver.Text = "<version>";
            // 
            // lbl_copy
            // 
            this.lbl_copy.AutoSize = true;
            this.lbl_copy.LinkColor = System.Drawing.Color.Gray;
            this.lbl_copy.Location = new System.Drawing.Point(114, 33);
            this.lbl_copy.Name = "lbl_copy";
            this.lbl_copy.Size = new System.Drawing.Size(42, 13);
            this.lbl_copy.TabIndex = 4;
            this.lbl_copy.TabStop = true;
            this.lbl_copy.Text = "<copy>";
            this.lbl_copy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_copy_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Design: STAM\r\nCode: KastHack";
            // 
            // FrmAbout
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 120);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_copy);
            this.Controls.Add(this.lbl_ver);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EpicMorg: RarJpeg Tool";
             ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_ver;
        private System.Windows.Forms.LinkLabel lbl_copy;
        private System.Windows.Forms.Label label1;
    }
}