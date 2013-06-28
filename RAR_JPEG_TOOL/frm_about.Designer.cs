namespace RJT
{
    partial class frm_about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_about));
            this.txt_hide = new System.Windows.Forms.LinkLabel();
            this.txt_about = new System.Windows.Forms.Label();
            this.txt_version = new System.Windows.Forms.Label();
            this.txt_null002 = new System.Windows.Forms.Label();
            this.txt_null001 = new System.Windows.Forms.Label();
            this.txt_about_ok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_hide
            // 
            this.txt_hide.AutoSize = true;
            this.txt_hide.Location = new System.Drawing.Point(74, 60);
            this.txt_hide.Name = "txt_hide";
            this.txt_hide.Size = new System.Drawing.Size(131, 13);
            this.txt_hide.TabIndex = 10;
            this.txt_hide.TabStop = true;
            this.txt_hide.Text = ">>> http://epicm.org/ <<<";
            this.txt_hide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_hide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txt_hide_LinkClicked);
            // 
            // txt_about
            // 
            this.txt_about.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_about.ForeColor = System.Drawing.Color.Black;
            this.txt_about.Location = new System.Drawing.Point(16, 91);
            this.txt_about.Name = "txt_about";
            this.txt_about.Size = new System.Drawing.Size(265, 101);
            this.txt_about.TabIndex = 8;
            this.txt_about.Text = "Translate - STAM && KastHack\r\nDesign - STAM && KastHack\r\nManual - STAM, Nekto, Ka" +
    "stHack, Certain\r\nCode - STAM && KastHack\r\nHelp in coding - KastHack\r\nSpcial than" +
    "ks - Nekto\r\nTesting - Certain\r\n";
            // 
            // txt_version
            // 
            this.txt_version.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_version.ForeColor = System.Drawing.Color.Black;
            this.txt_version.Location = new System.Drawing.Point(256, 49);
            this.txt_version.Name = "txt_version";
            this.txt_version.Size = new System.Drawing.Size(86, 15);
            this.txt_version.TabIndex = 9;
            this.txt_version.Text = "0.0.0.0";
            // 
            // txt_null002
            // 
            this.txt_null002.AutoSize = true;
            this.txt_null002.Location = new System.Drawing.Point(74, 34);
            this.txt_null002.Name = "txt_null002";
            this.txt_null002.Size = new System.Drawing.Size(138, 13);
            this.txt_null002.TabIndex = 7;
            this.txt_null002.Text = "Copyright © EpicMorg 2011";
            // 
            // txt_null001
            // 
            this.txt_null001.AutoSize = true;
            this.txt_null001.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_null001.Location = new System.Drawing.Point(74, 12);
            this.txt_null001.Name = "txt_null001";
            this.txt_null001.Size = new System.Drawing.Size(197, 16);
            this.txt_null001.TabIndex = 6;
            this.txt_null001.Text = "Easy Pic-to-Archive Merger";
            // 
            // txt_about_ok
            // 
            this.txt_about_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_about_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_about_ok.Location = new System.Drawing.Point(277, 12);
            this.txt_about_ok.Name = "txt_about_ok";
            this.txt_about_ok.Size = new System.Drawing.Size(65, 23);
            this.txt_about_ok.TabIndex = 4;
            this.txt_about_ok.Text = "&OK";
            this.txt_about_ok.UseVisualStyleBackColor = true;
            this.txt_about_ok.Click += new System.EventHandler(this.txt_about_ok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::RJT.Properties.Resources.res3;
            this.pictureBox1.Location = new System.Drawing.Point(287, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pic_logo
            // 
            this.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_logo.Image = global::RJT.Properties.Resources.icon1;
            this.pic_logo.Location = new System.Drawing.Point(16, 12);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(52, 52);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_logo.TabIndex = 5;
            this.pic_logo.TabStop = false;
            // 
            // frm_about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 84);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_hide);
            this.Controls.Add(this.txt_about);
            this.Controls.Add(this.txt_version);
            this.Controls.Add(this.txt_null002);
            this.Controls.Add(this.txt_null001);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.txt_about_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_about";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_about";
            this.Load += new System.EventHandler(this.frm_about_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel txt_hide;
        private System.Windows.Forms.Label txt_about;
        private System.Windows.Forms.Label txt_version;
        private System.Windows.Forms.Label txt_null002;
        private System.Windows.Forms.Label txt_null001;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Button txt_about_ok;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}