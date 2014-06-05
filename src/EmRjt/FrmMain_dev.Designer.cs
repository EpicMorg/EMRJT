namespace EmRjt {
    partial class FrmMain_dev {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.btnBrowseImg = new System.Windows.Forms.Button();
            this.chkBuiltinImg = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ofdSourceImg = new System.Windows.Forms.OpenFileDialog();
            this.ofdSourceFile = new System.Windows.Forms.OpenFileDialog();
            this.fbdSourceDir = new System.Windows.Forms.FolderBrowserDialog();
            this.sfdDestImg = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source image";
            // 
            // txtImg
            // 
            this.txtImg.Location = new System.Drawing.Point(16, 40);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(281, 20);
            this.txtImg.TabIndex = 1;
            // 
            // btnBrowseImg
            // 
            this.btnBrowseImg.Location = new System.Drawing.Point(318, 40);
            this.btnBrowseImg.Name = "btnBrowseImg";
            this.btnBrowseImg.Size = new System.Drawing.Size(75, 20);
            this.btnBrowseImg.TabIndex = 2;
            this.btnBrowseImg.Text = "...";
            this.btnBrowseImg.UseVisualStyleBackColor = true;
            this.btnBrowseImg.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkBuiltinImg
            // 
            this.chkBuiltinImg.AutoSize = true;
            this.chkBuiltinImg.Location = new System.Drawing.Point(414, 40);
            this.chkBuiltinImg.Name = "chkBuiltinImg";
            this.chkBuiltinImg.Size = new System.Drawing.Size(87, 17);
            this.chkBuiltinImg.TabIndex = 3;
            this.chkBuiltinImg.Text = "1-pixel image";
            this.chkBuiltinImg.UseVisualStyleBackColor = true;
            this.chkBuiltinImg.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Source file/directory";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(16, 113);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(281, 20);
            this.txtData.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Destination";
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(16, 186);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(281, 20);
            this.txtOut.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 8;
            this.button2.Text = "File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(414, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 20);
            this.button3.TabIndex = 9;
            this.button3.Text = "Folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(473, 40);
            this.button4.TabIndex = 10;
            this.button4.Text = "Merge!";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(318, 186);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 19);
            this.button5.TabIndex = 11;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ofdSourceFile
            // 
            this.ofdSourceFile.FileName = "openFileDialog1";
            // 
            // FrmMain_dev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 299);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkBuiltinImg);
            this.Controls.Add(this.btnBrowseImg);
            this.Controls.Add(this.txtImg);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain_dev";
            this.Text = "EMRJT";
            this.Load += new System.EventHandler(this.FrmMain_dev_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.Button btnBrowseImg;
        private System.Windows.Forms.CheckBox chkBuiltinImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog ofdSourceImg;
        private System.Windows.Forms.OpenFileDialog ofdSourceFile;
        private System.Windows.Forms.FolderBrowserDialog fbdSourceDir;
        private System.Windows.Forms.SaveFileDialog sfdDestImg;
    }
}

