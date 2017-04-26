namespace EMGRJT
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
            this.p2 = new System.Windows.Forms.Panel();
            this.msgPicHelp = new System.Windows.Forms.Label();
            this.s2 = new System.Windows.Forms.PictureBox();
            this.panel_output = new System.Windows.Forms.Panel();
            this.msgRarJpegHelp = new System.Windows.Forms.Label();
            this.pOS = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.Panel();
            this.msgArchHelp = new System.Windows.Forms.Label();
            this.s1 = new System.Windows.Forms.PictureBox();
            this.sfdOut = new System.Windows.Forms.SaveFileDialog();
            this.p2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s2)).BeginInit();
            this.panel_output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOS)).BeginInit();
            this.p1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s1)).BeginInit();
            this.SuspendLayout();
            // 
            // p2
            // 
            this.p2.AllowDrop = true;
            this.p2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.p2.BackgroundImage = global::EMGRJT.Properties.Resources.picture;
            this.p2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.p2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p2.Controls.Add(this.msgPicHelp);
            this.p2.Controls.Add(this.s2);
            this.p2.Location = new System.Drawing.Point(12, 138);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(120, 120);
            this.p2.TabIndex = 1;
            this.p2.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_input2_DragDrop);
            this.p2.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_input2_DragEnter);
            // 
            // msgPicHelp
            // 
            this.msgPicHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msgPicHelp.Location = new System.Drawing.Point(0, 82);
            this.msgPicHelp.Name = "msgPicHelp";
            this.msgPicHelp.Size = new System.Drawing.Size(116, 34);
            this.msgPicHelp.TabIndex = 3;
            this.msgPicHelp.Text = "2. Drag picture here";
            this.msgPicHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // s2
            // 
            this.s2.Image = global::EMGRJT.Properties.Resources.cancel;
            this.s2.Location = new System.Drawing.Point(97, 3);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(16, 16);
            this.s2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.s2.TabIndex = 1;
            this.s2.TabStop = false;
            // 
            // panel_output
            // 
            this.panel_output.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_output.BackgroundImage = global::EMGRJT.Properties.Resources.rarjpegpic;
            this.panel_output.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_output.Controls.Add(this.msgRarJpegHelp);
            this.panel_output.Controls.Add(this.pOS);
            this.panel_output.Location = new System.Drawing.Point(139, 12);
            this.panel_output.Name = "panel_output";
            this.panel_output.Size = new System.Drawing.Size(246, 246);
            this.panel_output.TabIndex = 0;
            this.panel_output.Click += new System.EventHandler(this.panel_output_Click);
            // 
            // msgRarJpegHelp
            // 
            this.msgRarJpegHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msgRarJpegHelp.Location = new System.Drawing.Point(0, 208);
            this.msgRarJpegHelp.Name = "msgRarJpegHelp";
            this.msgRarJpegHelp.Size = new System.Drawing.Size(242, 34);
            this.msgRarJpegHelp.TabIndex = 4;
            this.msgRarJpegHelp.Text = "3. Get RarJpeg here";
            this.msgRarJpegHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pOS
            // 
            this.pOS.Image = global::EMGRJT.Properties.Resources.cancel;
            this.pOS.Location = new System.Drawing.Point(223, 3);
            this.pOS.Name = "pOS";
            this.pOS.Size = new System.Drawing.Size(16, 16);
            this.pOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pOS.TabIndex = 1;
            this.pOS.TabStop = false;
            // 
            // p1
            // 
            this.p1.AllowDrop = true;
            this.p1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.p1.BackgroundImage = global::EMGRJT.Properties.Resources.archive;
            this.p1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.p1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p1.Controls.Add(this.msgArchHelp);
            this.p1.Controls.Add(this.s1);
            this.p1.ForeColor = System.Drawing.Color.Black;
            this.p1.Location = new System.Drawing.Point(12, 12);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(120, 120);
            this.p1.TabIndex = 0;
            this.p1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_input1_DragDrop);
            this.p1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_input1_DragEnter);
            // 
            // msgArchHelp
            // 
            this.msgArchHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msgArchHelp.Location = new System.Drawing.Point(0, 82);
            this.msgArchHelp.Name = "msgArchHelp";
            this.msgArchHelp.Size = new System.Drawing.Size(116, 34);
            this.msgArchHelp.TabIndex = 2;
            this.msgArchHelp.Text = "1. Drag archive here";
            this.msgArchHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // s1
            // 
            this.s1.Image = global::EMGRJT.Properties.Resources.cancel;
            this.s1.Location = new System.Drawing.Point(97, 3);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(16, 16);
            this.s1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.s1.TabIndex = 0;
            this.s1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(397, 270);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.panel_output);
            this.Controls.Add(this.p1);
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
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s2)).EndInit();
            this.panel_output.ResumeLayout(false);
            this.panel_output.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOS)).EndInit();
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel panel_output;
        private System.Windows.Forms.PictureBox s1;
        private System.Windows.Forms.PictureBox s2;
        private System.Windows.Forms.PictureBox pOS;
        private System.Windows.Forms.SaveFileDialog sfdOut;
        private System.Windows.Forms.Label msgArchHelp;
        private System.Windows.Forms.Label msgPicHelp;
        private System.Windows.Forms.Label msgRarJpegHelp;
    }
}