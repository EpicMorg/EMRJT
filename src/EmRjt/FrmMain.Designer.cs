namespace EmRjt
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel_input2 = new System.Windows.Forms.Panel();
            this.pic_input_status2 = new System.Windows.Forms.PictureBox();
            this.panel_output = new System.Windows.Forms.Panel();
            this.progressbar_output = new System.Windows.Forms.ProgressBar();
            this.pic_output_status = new System.Windows.Forms.PictureBox();
            this.panel_input1 = new System.Windows.Forms.Panel();
            this.pic_input_status1 = new System.Windows.Forms.PictureBox();
            this.panel_input2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_input_status2)).BeginInit();
            this.panel_output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_output_status)).BeginInit();
            this.panel_input1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_input_status1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_input2
            // 
            this.panel_input2.AllowDrop = true;
            this.panel_input2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_input2.BackgroundImage = global::EmRjt.Properties.Resources.picture;
            this.panel_input2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_input2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_input2.Controls.Add(this.pic_input_status2);
            this.panel_input2.Location = new System.Drawing.Point(12, 138);
            this.panel_input2.Name = "panel_input2";
            this.panel_input2.Size = new System.Drawing.Size(120, 120);
            this.panel_input2.TabIndex = 1;
            // 
            // pic_input_status2
            // 
            this.pic_input_status2.Image = global::EmRjt.Properties.Resources.cancel;
            this.pic_input_status2.Location = new System.Drawing.Point(97, 3);
            this.pic_input_status2.Name = "pic_input_status2";
            this.pic_input_status2.Size = new System.Drawing.Size(16, 16);
            this.pic_input_status2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_input_status2.TabIndex = 1;
            this.pic_input_status2.TabStop = false;
            // 
            // panel_output
            // 
            this.panel_output.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_output.BackgroundImage = global::EmRjt.Properties.Resources.rarjpegpic;
            this.panel_output.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_output.Controls.Add(this.progressbar_output);
            this.panel_output.Controls.Add(this.pic_output_status);
            this.panel_output.Location = new System.Drawing.Point(139, 12);
            this.panel_output.Name = "panel_output";
            this.panel_output.Size = new System.Drawing.Size(246, 246);
            this.panel_output.TabIndex = 0;
            // 
            // progressbar_output
            // 
            this.progressbar_output.ForeColor = System.Drawing.Color.Lime;
            this.progressbar_output.Location = new System.Drawing.Point(77, 171);
            this.progressbar_output.Name = "progressbar_output";
            this.progressbar_output.Size = new System.Drawing.Size(87, 16);
            this.progressbar_output.TabIndex = 2;
            // 
            // pic_output_status
            // 
            this.pic_output_status.Image = global::EmRjt.Properties.Resources.cancel;
            this.pic_output_status.Location = new System.Drawing.Point(223, 3);
            this.pic_output_status.Name = "pic_output_status";
            this.pic_output_status.Size = new System.Drawing.Size(16, 16);
            this.pic_output_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_output_status.TabIndex = 1;
            this.pic_output_status.TabStop = false;
            // 
            // panel_input1
            // 
            this.panel_input1.AllowDrop = true;
            this.panel_input1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_input1.BackgroundImage = global::EmRjt.Properties.Resources.archive;
            this.panel_input1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_input1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_input1.Controls.Add(this.pic_input_status1);
            this.panel_input1.ForeColor = System.Drawing.Color.Black;
            this.panel_input1.Location = new System.Drawing.Point(12, 12);
            this.panel_input1.Name = "panel_input1";
            this.panel_input1.Size = new System.Drawing.Size(120, 120);
            this.panel_input1.TabIndex = 0;
            // 
            // pic_input_status1
            // 
            this.pic_input_status1.Image = global::EmRjt.Properties.Resources.cancel;
            this.pic_input_status1.Location = new System.Drawing.Point(97, 3);
            this.pic_input_status1.Name = "pic_input_status1";
            this.pic_input_status1.Size = new System.Drawing.Size(16, 16);
            this.pic_input_status1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_input_status1.TabIndex = 0;
            this.pic_input_status1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(397, 270);
            this.Controls.Add(this.panel_input2);
            this.Controls.Add(this.panel_output);
            this.Controls.Add(this.panel_input1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(413, 309);
            this.MinimumSize = new System.Drawing.Size(413, 309);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EpicMorg: RarJpeg Tool";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Click += new System.EventHandler(this.FrmMain_Click);
            this.panel_input2.ResumeLayout(false);
            this.panel_input2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_input_status2)).EndInit();
            this.panel_output.ResumeLayout(false);
            this.panel_output.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_output_status)).EndInit();
            this.panel_input1.ResumeLayout(false);
            this.panel_input1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_input_status1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_input1;
        private System.Windows.Forms.Panel panel_input2;
        private System.Windows.Forms.Panel panel_output;
        private System.Windows.Forms.PictureBox pic_input_status1;
        private System.Windows.Forms.PictureBox pic_input_status2;
        private System.Windows.Forms.PictureBox pic_output_status;
        private System.Windows.Forms.ProgressBar progressbar_output;
    }
}