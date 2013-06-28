namespace RJT
{
    partial class frm_chalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_chalog));
            this.pic_picture1 = new System.Windows.Forms.PictureBox();
            this.lbl_program_name_cl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cl_close = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_picture1
            // 
            this.pic_picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_picture1.Image = global::RJT.Properties.Resources.res2;
            this.pic_picture1.InitialImage = null;
            this.pic_picture1.Location = new System.Drawing.Point(12, 12);
            this.pic_picture1.Name = "pic_picture1";
            this.pic_picture1.Size = new System.Drawing.Size(46, 46);
            this.pic_picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_picture1.TabIndex = 1;
            this.pic_picture1.TabStop = false;
            // 
            // lbl_program_name_cl
            // 
            this.lbl_program_name_cl.AutoSize = true;
            this.lbl_program_name_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_program_name_cl.Location = new System.Drawing.Point(64, 12);
            this.lbl_program_name_cl.Name = "lbl_program_name_cl";
            this.lbl_program_name_cl.Size = new System.Drawing.Size(216, 16);
            this.lbl_program_name_cl.TabIndex = 2;
            this.lbl_program_name_cl.Text = "История Версий Программы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Easy Pic-To-Archive Merger (aka Rar Jpeg Tool)";
            // 
            // btn_cl_close
            // 
            this.btn_cl_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cl_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cl_close.Location = new System.Drawing.Point(306, 12);
            this.btn_cl_close.Name = "btn_cl_close";
            this.btn_cl_close.Size = new System.Drawing.Size(66, 23);
            this.btn_cl_close.TabIndex = 3;
            this.btn_cl_close.Text = "&OK";
            this.btn_cl_close.UseVisualStyleBackColor = true;
            this.btn_cl_close.Click += new System.EventHandler(this.btn_cl_close_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(360, 136);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // frm_chalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_cl_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_program_name_cl);
            this.Controls.Add(this.pic_picture1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "frm_chalog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Log";
            this.Load += new System.EventHandler(this.frm_chalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_picture1;
        private System.Windows.Forms.Label lbl_program_name_cl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cl_close;
        private System.Windows.Forms.TextBox textBox1;
    }
}