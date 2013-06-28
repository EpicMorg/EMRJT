using System;
using System.IO;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
namespace RJT
{
    public partial class frm_main : Form
    {
		#region Translation fuctions
        public string _(string key)
        {
          return Translation.Texts[key];
        }
        public void translatemenus(ToolStripMenuItem pr)
        {
            pr.Text = Translation.Texts[pr.Name];
            foreach(ToolStripItem dr in pr.DropDownItems)
            {
                try
                {
                    translatemenus((ToolStripMenuItem)dr);
                }
                catch { }
            }
        }
        public void translate()
        {
            foreach (Control parentctr in this.Controls)
            {
                try
                {
                    parentctr.Text = _(parentctr.Name);
                }
                catch { }
                foreach (Control ctr in parentctr.Controls)
                {
                    int i = 0;
                    try
                    {
                        ctr.Text = _(ctr.Name);
                        i++;
                    }
                    catch { }
                }
                foreach (ToolStripMenuItem ts in this.MainMenuStrip.Items)
                {
                    translatemenus(ts);
                }
            }
        }
        #endregion
		public frm_main()
        {
            InitializeComponent();
        }
        bool FileOrFolder = false;
        private void fail(Exception ex)
        {
                MessageBox.Show(_("msg_error")+Environment.NewLine + ex.Message, _("msg_fail"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void win(string path)
        {
                if ( MessageBox.Show(_("msg_success"), _("msg_win"), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    System.Diagnostics.Process.Start(path.Substring(0, path.LastIndexOf(Environment.OSVersion.Platform.ToString().ToLower().Contains("win") ? '\\' : '/')));
        }
        private bool build(string image, bool Internal, string Content, bool compress, string merged)
        {
			#region add files
            #region output already exists
            if (File.Exists(merged))
            {
                try
                {
                    File.Delete(merged);
                }
                catch { return false; }
            }
            #endregion
            #region zip files
            if (compress)
            {
                FastZip z = new FastZip();
                if (File.Exists(Content))//Compress file
                {
                        z.CreateEmptyDirectories = false;
                        z.CreateZip(merged, Path.GetDirectoryName(Content),false, Path.GetFileName(Content));
                }
                else
                {
                    if (Directory.Exists(Content))
                    {
                        z.CreateEmptyDirectories = true;
                        z.CreateZip(merged, Content, true, "");
                    }
                    else return false;
                }
            }
			#endregion
			#region copy files to output
            else
            {
                if (File.Exists(Content))//Add file
                    File.Copy(Content, merged, true);
                else
                {
                    if (Directory.Exists(Content))//Add directory 
                        throw new InvalidOperationException(_("you_want_to_get_impossible_things"));//,_("msg_error"),MessageBoxButtons.OK,MessageBoxIcon.Error);
                    else return false;//Nothing to do
                }
            }
			#endregion
            #region draw watermark
            #region write image to end of file

            //read image
            byte[] img = Internal ? (byte[]) Properties.Resources.ResourceManager.GetObject(image) : File.ReadAllBytes(image);
            #endregion
            try
            {
                //if file is less than 128 mb
                if (new FileInfo(merged).Length < (2 << 26))
                {
                    File.WriteAllBytes(merged, img.Concat<byte>(File.ReadAllBytes(merged)).ToArray());
                    img = null;
                }
                else
                {
                    #region prepare output
                    //open output file
                    Stream outstream = new FileStream(merged, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    //create 64mb buffer
                    byte[] buff = new byte[2 << 25];
                    //grow output file
                    outstream.SetLength(outstream.Length + img.LongLength);
#endregion
                    #region move bytes to end
                    outstream.Seek(0, SeekOrigin.End);
                    int i = 0;//read count
                    long output_length=outstream.Length,buff_l=buff.LongLength,img_l=img.LongLength;
                    while (output_length - buff_l * (i + 1) - img_l > 0)
                    {
                        outstream.Seek(-img_l - buff_l, SeekOrigin.Current);
                        //outstream.Seek(-buff_l, SeekOrigin.Current);
                        outstream.Read(buff, 0, buff.Length);
                        outstream.Seek(-buff_l+img_l, SeekOrigin.Current);
                        //outstream.Seek(img_l, SeekOrigin.Current);
                        outstream.Write(buff, 0, buff.Length);
                        outstream.Seek(-buff_l, SeekOrigin.Current);
                        i++;
                    }
                    if (output_length - buff_l * i - img_l > 0)
                    {
                        buff = null;
                        buff = new byte[output_length - buff_l * i - img_l];
                        outstream.Seek(0, SeekOrigin.Begin);
                        outstream.Read(buff, 0, buff.Length);
                        outstream.Seek(img_l, SeekOrigin.Begin);
                        outstream.Write(buff, 0, buff.Length);
                    }
#endregion
                    #region write image and flush
                    outstream.Seek(0, SeekOrigin.Begin);
                    outstream.Write(img, 0, img.Length);
                    outstream.Flush();
                    outstream.Close();
                    #endregion
                }
            }
            catch
            {
                return false;
            }
            #endregion
            return true;
			#endregion
        }
        private void chk_built_in_CheckedChanged(object sender, EventArgs e)
        {
            txt_picture_path.Enabled = !chk_built_in.Checked;
            btn_browse_pic.Enabled = !chk_built_in.Checked;
        }
        private void btn_browse_pic_Click(object sender, EventArgs e)
        {
            if (ofd_image.ShowDialog() == DialogResult.OK)
                txt_picture_path.Text = ofd_image.FileName;
        }
        private void btn_browse_file_Click(object sender, EventArgs e)
        {
            if (ofd_content.ShowDialog() == DialogResult.OK)
            {
                txt_content_path.Text = ofd_content.FileName;
                FileOrFolder = false;
            }
        }
        private void btn_browse_path_Click(object sender, EventArgs e)
        {
            if (fld_content.ShowDialog() == DialogResult.OK)
            {
                txt_content_path.Text = fld_content.SelectedPath;
                FileOrFolder = true;
            }
        }
        private void btn_savepath_Click(object sender, EventArgs e)
        {
            if (sfd_merge.ShowDialog() == DialogResult.OK)
                txt_newmerg_name.Text = sfd_merge.FileName;
        }
        private void btn_merge_Click(object sender, EventArgs e)
        {
            //===proverka===poley=============================
            #region no image
            if (!(File.Exists(txt_picture_path.Text) || chk_built_in.Checked))
            {
                MessageBox.Show(_("msg_image_not_found"), _("msg_attention"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion
            #region no input
            if (!(File.Exists(txt_content_path.Text) || Directory.Exists(txt_content_path.Text)))
            {
                MessageBox.Show(_("msg_archive_not_found"), _("msg_attention"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion
            #region no output
            if (!Directory.Exists(Path.GetDirectoryName(txt_newmerg_name.Text)) && !Directory.Exists(txt_newmerg_name.Text))
            {
                MessageBox.Show(_("msg_output_not_set"), _("msg_attention"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion
            #region User tries to write output to input file or image file
            if (txt_content_path.Text == txt_newmerg_name.Text || txt_newmerg_name.Text == txt_picture_path.Text || txt_picture_path.Text == txt_content_path.Text)
            {
                fail(new InvalidOperationException("You can't write output to input files!"));
                return;
            }
#endregion
            #region everything is ok
            try
            {
                prgr_merge.Value = 0;
                string input_file = txt_content_path.Text;
                string output_file = txt_newmerg_name.Text;
                {
                    if (build(chk_built_in.Checked ? "pixel" : txt_picture_path.Text,
                        chk_built_in.Checked,
                        input_file,
                        (FileOrFolder||!ofd_content.Filter.ToLower().Contains("*"+Path.GetExtension(txt_content_path.Text).ToLower())),//Compress if it's folder or not archive
                        txt_newmerg_name.Text))
                    {
                        prgr_merge.Value = 100;
                        win(output_file);
                    }
                    else fail(new Exception("Error!")); 
                }
            }
            catch (System.Exception ex)
            {
                fail(ex);
            }
            #endregion
        }
        private void tsmi_about_Click(object sender, EventArgs e)
        {
            frm_about About = new frm_about();
            About.ShowDialog();
        }
        private void tsmi_english_Click_1(object sender, EventArgs e)
        {
            tsmi_russian.Checked =tsmi_english.Checked? false:tsmi_russian.Checked;
            Translation.Language = "eng";
            translate();
        }
        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tsmi_russian_Click(object sender, EventArgs e)
        {
            tsmi_english.Checked = tsmi_russian.Checked ? false : tsmi_english.Checked;
            Translation.Language = "rus";
            translate();
        }
        private void tsmi_help_Click(object sender, EventArgs e)
        {
          
            //this.Height =351+284-this.Height;
            //tsmi_help.Checked = this.Height == 284;
        }
        private void tsmi_chalog_Click(object sender, EventArgs e)
        {
            new frm_chalog().ShowDialog();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            if (CultureInfo.CurrentUICulture.Name.ToLower().StartsWith("ru"))
            {
                tsmi_english.Checked = tsmi_russian.Checked ? false : tsmi_english.Checked;
                Translation.Language = "rus";
                translate();
            }
            try
            {
                brsSpam.Document.Body.ScrollIntoView(true);
            }
            catch { }
        }

        private void brsSpam_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                brsSpam.Document.Body.ScrollIntoView(true);
            }
            catch { }
        }
    }
}
/*
*/