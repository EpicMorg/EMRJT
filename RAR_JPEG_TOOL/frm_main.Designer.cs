namespace RJT
{
    partial class frm_main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.tsmi_file = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_chalog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_language = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_russian = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_english = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_help_main = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_manual = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_about = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_main = new System.Windows.Forms.GroupBox();
            this.btn_browse_file = new System.Windows.Forms.Button();
            this.btn_savepath = new System.Windows.Forms.Button();
            this.prgr_merge = new System.Windows.Forms.ProgressBar();
            this.lbl_newmerg_name = new System.Windows.Forms.Label();
            this.lbl_rar_path = new System.Windows.Forms.Label();
            this.lbl_picture_path = new System.Windows.Forms.Label();
            this.txt_newmerg_name = new System.Windows.Forms.TextBox();
            this.txt_content_path = new System.Windows.Forms.TextBox();
            this.txt_picture_path = new System.Windows.Forms.TextBox();
            this.btn_merge = new System.Windows.Forms.Button();
            this.btn_browse_path = new System.Windows.Forms.Button();
            this.btn_browse_pic = new System.Windows.Forms.Button();
            this.chk_built_in = new System.Windows.Forms.CheckBox();
            this.sfd_merge = new System.Windows.Forms.SaveFileDialog();
            this.fld_content = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd_image = new System.Windows.Forms.OpenFileDialog();
            this.ofd_content = new System.Windows.Forms.OpenFileDialog();
            this.btn_f1_hlp = new System.Windows.Forms.HelpProvider();
            this.brsSpam = new System.Windows.Forms.WebBrowser();
            this.menu_main = new System.Windows.Forms.MenuStrip();
            this.gb_main.SuspendLayout();
            this.menu_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsmi_file
            // 
            this.tsmi_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_chalog,
            this.toolStripSeparator3,
            this.tsmi_exit});
            this.tsmi_file.Image = global::RJT.Properties.Resources.fl;
            this.tsmi_file.Name = "tsmi_file";
            this.tsmi_file.Size = new System.Drawing.Size(53, 20);
            this.tsmi_file.Text = "File";
            // 
            // tsmi_chalog
            // 
            this.tsmi_chalog.Image = global::RJT.Properties.Resources.cl;
            this.tsmi_chalog.Name = "tsmi_chalog";
            this.tsmi_chalog.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsmi_chalog.Size = new System.Drawing.Size(154, 22);
            this.tsmi_chalog.Text = "ChangeLog";
            this.tsmi_chalog.Click += new System.EventHandler(this.tsmi_chalog_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(151, 6);
            // 
            // tsmi_exit
            // 
            this.tsmi_exit.Image = global::RJT.Properties.Resources.exit;
            this.tsmi_exit.Name = "tsmi_exit";
            this.tsmi_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.tsmi_exit.Size = new System.Drawing.Size(154, 22);
            this.tsmi_exit.Text = "Exit";
            this.tsmi_exit.Click += new System.EventHandler(this.tsmi_exit_Click);
            // 
            // tsmi_edit
            // 
            this.tsmi_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_language});
            this.tsmi_edit.Image = global::RJT.Properties.Resources.sttm;
            this.tsmi_edit.Name = "tsmi_edit";
            this.tsmi_edit.Size = new System.Drawing.Size(55, 20);
            this.tsmi_edit.Text = "Edit";
            // 
            // tsmi_language
            // 
            this.tsmi_language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_russian,
            this.tsmi_english});
            this.tsmi_language.Name = "tsmi_language";
            this.tsmi_language.Size = new System.Drawing.Size(126, 22);
            this.tsmi_language.Text = "Language";
            // 
            // tsmi_russian
            // 
            this.tsmi_russian.CheckOnClick = true;
            this.tsmi_russian.Image = global::RJT.Properties.Resources.russian;
            this.tsmi_russian.Name = "tsmi_russian";
            this.tsmi_russian.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.tsmi_russian.Size = new System.Drawing.Size(187, 22);
            this.tsmi_russian.Text = "Russian";
            this.tsmi_russian.Click += new System.EventHandler(this.tsmi_russian_Click);
            // 
            // tsmi_english
            // 
            this.tsmi_english.Checked = true;
            this.tsmi_english.CheckOnClick = true;
            this.tsmi_english.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_english.Image = global::RJT.Properties.Resources.engl;
            this.tsmi_english.Name = "tsmi_english";
            this.tsmi_english.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.tsmi_english.Size = new System.Drawing.Size(187, 22);
            this.tsmi_english.Text = "English";
            this.tsmi_english.Click += new System.EventHandler(this.tsmi_english_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmi_help_main
            // 
            this.tsmi_help_main.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_manual,
            this.tsmi_about});
            this.tsmi_help_main.Image = global::RJT.Properties.Resources.helpm;
            this.tsmi_help_main.Name = "tsmi_help_main";
            this.tsmi_help_main.Size = new System.Drawing.Size(60, 20);
            this.tsmi_help_main.Text = "Help";
            // 
            // tsmi_manual
            // 
            this.tsmi_manual.Enabled = false;
            this.tsmi_manual.Image = global::RJT.Properties.Resources.helppm;
            this.tsmi_manual.Name = "tsmi_manual";
            this.tsmi_manual.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsmi_manual.Size = new System.Drawing.Size(149, 22);
            this.tsmi_manual.Text = "Manual";
            // 
            // tsmi_about
            // 
            this.tsmi_about.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_about.Image")));
            this.tsmi_about.Name = "tsmi_about";
            this.tsmi_about.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmi_about.Size = new System.Drawing.Size(152, 22);
            this.tsmi_about.Text = "About";
            this.tsmi_about.Click += new System.EventHandler(this.tsmi_about_Click);
            // 
            // gb_main
            // 
            this.gb_main.Controls.Add(this.btn_browse_file);
            this.gb_main.Controls.Add(this.btn_savepath);
            this.gb_main.Controls.Add(this.prgr_merge);
            this.gb_main.Controls.Add(this.lbl_newmerg_name);
            this.gb_main.Controls.Add(this.lbl_rar_path);
            this.gb_main.Controls.Add(this.lbl_picture_path);
            this.gb_main.Controls.Add(this.txt_newmerg_name);
            this.gb_main.Controls.Add(this.txt_content_path);
            this.gb_main.Controls.Add(this.txt_picture_path);
            this.gb_main.Controls.Add(this.btn_merge);
            this.gb_main.Controls.Add(this.btn_browse_path);
            this.gb_main.Controls.Add(this.btn_browse_pic);
            this.gb_main.Location = new System.Drawing.Point(11, 26);
            this.gb_main.Name = "gb_main";
            this.gb_main.Size = new System.Drawing.Size(443, 210);
            this.gb_main.TabIndex = 1;
            this.gb_main.TabStop = false;
            this.gb_main.Text = "Settings";
            // 
            // btn_browse_file
            // 
            this.btn_browse_file.Location = new System.Drawing.Point(249, 93);
            this.btn_browse_file.Name = "btn_browse_file";
            this.btn_browse_file.Size = new System.Drawing.Size(78, 22);
            this.btn_browse_file.TabIndex = 5;
            this.btn_browse_file.Text = "File";
            this.btn_browse_file.UseVisualStyleBackColor = true;
            this.btn_browse_file.Click += new System.EventHandler(this.btn_browse_file_Click);
            // 
            // btn_savepath
            // 
            this.btn_savepath.Location = new System.Drawing.Point(249, 144);
            this.btn_savepath.Name = "btn_savepath";
            this.btn_savepath.Size = new System.Drawing.Size(44, 22);
            this.btn_savepath.TabIndex = 4;
            this.btn_savepath.Text = "...";
            this.btn_savepath.UseVisualStyleBackColor = true;
            this.btn_savepath.Click += new System.EventHandler(this.btn_savepath_Click);
            // 
            // prgr_merge
            // 
            this.prgr_merge.ForeColor = System.Drawing.Color.Red;
            this.prgr_merge.Location = new System.Drawing.Point(6, 182);
            this.prgr_merge.Name = "prgr_merge";
            this.prgr_merge.Size = new System.Drawing.Size(431, 22);
            this.prgr_merge.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgr_merge.TabIndex = 3;
            // 
            // lbl_newmerg_name
            // 
            this.lbl_newmerg_name.AutoSize = true;
            this.lbl_newmerg_name.Location = new System.Drawing.Point(6, 129);
            this.lbl_newmerg_name.Name = "lbl_newmerg_name";
            this.lbl_newmerg_name.Size = new System.Drawing.Size(119, 13);
            this.lbl_newmerg_name.TabIndex = 2;
            this.lbl_newmerg_name.Text = "New merged-file\'s name";
            // 
            // lbl_rar_path
            // 
            this.lbl_rar_path.AutoSize = true;
            this.lbl_rar_path.Location = new System.Drawing.Point(3, 76);
            this.lbl_rar_path.Name = "lbl_rar_path";
            this.lbl_rar_path.Size = new System.Drawing.Size(96, 13);
            this.lbl_rar_path.TabIndex = 2;
            this.lbl_rar_path.Text = "Path to Archive-file";
            // 
            // lbl_picture_path
            // 
            this.lbl_picture_path.AutoSize = true;
            this.lbl_picture_path.Location = new System.Drawing.Point(6, 26);
            this.lbl_picture_path.Name = "lbl_picture_path";
            this.lbl_picture_path.Size = new System.Drawing.Size(93, 13);
            this.lbl_picture_path.TabIndex = 2;
            this.lbl_picture_path.Text = "Path to Picture-file";
            // 
            // txt_newmerg_name
            // 
            this.txt_newmerg_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_newmerg_name.Location = new System.Drawing.Point(6, 144);
            this.txt_newmerg_name.Name = "txt_newmerg_name";
            this.txt_newmerg_name.Size = new System.Drawing.Size(227, 22);
            this.txt_newmerg_name.TabIndex = 1;
            // 
            // txt_content_path
            // 
            this.txt_content_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_content_path.Location = new System.Drawing.Point(6, 93);
            this.txt_content_path.Name = "txt_content_path";
            this.txt_content_path.Size = new System.Drawing.Size(227, 22);
            this.txt_content_path.TabIndex = 1;
            // 
            // txt_picture_path
            // 
            this.txt_picture_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_picture_path.Location = new System.Drawing.Point(6, 42);
            this.txt_picture_path.Name = "txt_picture_path";
            this.txt_picture_path.Size = new System.Drawing.Size(227, 22);
            this.txt_picture_path.TabIndex = 1;
            // 
            // btn_merge
            // 
            this.btn_merge.Location = new System.Drawing.Point(299, 144);
            this.btn_merge.Name = "btn_merge";
            this.btn_merge.Size = new System.Drawing.Size(138, 22);
            this.btn_merge.TabIndex = 0;
            this.btn_merge.Text = "&Merge";
            this.btn_merge.UseVisualStyleBackColor = true;
            this.btn_merge.Click += new System.EventHandler(this.btn_merge_Click);
            // 
            // btn_browse_path
            // 
            this.btn_browse_path.Location = new System.Drawing.Point(331, 93);
            this.btn_browse_path.Name = "btn_browse_path";
            this.btn_browse_path.Size = new System.Drawing.Size(106, 22);
            this.btn_browse_path.TabIndex = 0;
            this.btn_browse_path.Text = "Folder";
            this.btn_browse_path.UseVisualStyleBackColor = true;
            this.btn_browse_path.Click += new System.EventHandler(this.btn_browse_path_Click);
            // 
            // btn_browse_pic
            // 
            this.btn_browse_pic.Location = new System.Drawing.Point(249, 42);
            this.btn_browse_pic.Name = "btn_browse_pic";
            this.btn_browse_pic.Size = new System.Drawing.Size(78, 22);
            this.btn_browse_pic.TabIndex = 0;
            this.btn_browse_pic.Text = "Browse";
            this.btn_browse_pic.UseVisualStyleBackColor = true;
            this.btn_browse_pic.Click += new System.EventHandler(this.btn_browse_pic_Click);
            // 
            // chk_built_in
            // 
            this.chk_built_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_built_in.Location = new System.Drawing.Point(342, 47);
            this.chk_built_in.Name = "chk_built_in";
            this.chk_built_in.Size = new System.Drawing.Size(107, 66);
            this.chk_built_in.TabIndex = 6;
            this.chk_built_in.Text = "Built-in image";
            this.chk_built_in.UseVisualStyleBackColor = true;
            this.chk_built_in.CheckedChanged += new System.EventHandler(this.chk_built_in_CheckedChanged);
            // 
            // sfd_merge
            // 
            this.sfd_merge.Filter = resources.GetString("sfd_merge.Filter");
            this.sfd_merge.Title = "Select destination file";
            // 
            // fld_content
            // 
            this.fld_content.Description = "Select folder to add to archive";
            this.fld_content.ShowNewFolderButton = false;
            // 
            // ofd_image
            // 
            this.ofd_image.Filter = resources.GetString("ofd_image.Filter");
            this.ofd_image.Title = "Select image";
            // 
            // ofd_content
            // 
            this.ofd_content.Filter = resources.GetString("ofd_content.Filter");
            this.ofd_content.FilterIndex = 20;
            this.ofd_content.Title = "Select files";
            // 
            // btn_f1_hlp
            // 
            this.btn_f1_hlp.HelpNamespace = "";
            // 
            // brsSpam
            // 
            this.brsSpam.AllowWebBrowserDrop = false;
            this.brsSpam.IsWebBrowserContextMenuEnabled = false;
            this.brsSpam.Location = new System.Drawing.Point(9, 244);
            this.brsSpam.MinimumSize = new System.Drawing.Size(20, 20);
            this.brsSpam.Name = "brsSpam";
            this.brsSpam.ScriptErrorsSuppressed = true;
            this.brsSpam.ScrollBarsEnabled = false;
            this.brsSpam.Size = new System.Drawing.Size(443, 176);
            this.brsSpam.TabIndex = 7;
            this.brsSpam.Url = new System.Uri("http://download.epicm.org/EMRJT/support/index.html", System.UriKind.Absolute);
            this.brsSpam.WebBrowserShortcutsEnabled = false;
            this.brsSpam.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.brsSpam_DocumentCompleted);
            // 
            // menu_main
            // 
            this.menu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_file,
            this.tsmi_edit,
            this.tsmi_help_main});
            this.menu_main.Location = new System.Drawing.Point(0, 0);
            this.menu_main.Name = "menu_main";
            this.menu_main.Size = new System.Drawing.Size(464, 24);
            this.menu_main.TabIndex = 8;
            this.menu_main.Text = "menuStrip1";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 432);
            this.Controls.Add(this.brsSpam);
            this.Controls.Add(this.chk_built_in);
            this.Controls.Add(this.gb_main);
            this.Controls.Add(this.menu_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_main;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_main";
            this.btn_f1_hlp.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Pic-To-Archive Merger (aka Rar Jpeg Tool)";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.gb_main.ResumeLayout(false);
            this.gb_main.PerformLayout();
            this.menu_main.ResumeLayout(false);
            this.menu_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.ToolStripMenuItem tsmi_file;
        private System.Windows.Forms.ToolStripMenuItem tsmi_exit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_help_main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_about;
        private System.Windows.Forms.GroupBox gb_main;
        private System.Windows.Forms.CheckBox chk_built_in;
        private System.Windows.Forms.Button btn_browse_file;
        private System.Windows.Forms.Button btn_savepath;
        private System.Windows.Forms.ProgressBar prgr_merge;
        private System.Windows.Forms.Label lbl_newmerg_name;
        private System.Windows.Forms.Label lbl_rar_path;
        private System.Windows.Forms.Label lbl_picture_path;
        private System.Windows.Forms.TextBox txt_newmerg_name;
        private System.Windows.Forms.TextBox txt_content_path;
        private System.Windows.Forms.TextBox txt_picture_path;
        private System.Windows.Forms.Button btn_merge;
        private System.Windows.Forms.Button btn_browse_path;
        private System.Windows.Forms.Button btn_browse_pic;
        private System.Windows.Forms.SaveFileDialog sfd_merge;
        private System.Windows.Forms.FolderBrowserDialog fld_content;
        private System.Windows.Forms.OpenFileDialog ofd_image;
        private System.Windows.Forms.OpenFileDialog ofd_content;
        private System.Windows.Forms.ToolStripMenuItem tsmi_manual;
        private System.Windows.Forms.ToolStripMenuItem tsmi_chalog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_language;
        private System.Windows.Forms.ToolStripMenuItem tsmi_english;
        private System.Windows.Forms.ToolStripMenuItem tsmi_russian;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.HelpProvider btn_f1_hlp;
        private System.Windows.Forms.WebBrowser brsSpam;
        private System.Windows.Forms.MenuStrip menu_main;
    }
}

