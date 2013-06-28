using System;
using System.Reflection;
using System.Windows.Forms;

namespace RJT
{
    public partial class frm_about : Form
    {
        public frm_about()
        {
            InitializeComponent();
           this.Text = String.Format("About ''{0}''", AssemblyTitle);
            this.txt_version.Text = String.Format("Version {0}", AssemblyVersion);
            this.txt_null002.Text =  AssemblyCopyright;
        }

        #region Методы доступа к атрибутам сборки

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion




        private void txt_hide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.Height < 200)
            {
                this.Height = 237;
                txt_hide.Text = "<<< http://epicm.org/ >>>";
            }
            else
            {
                this.Height = 116;
                txt_hide.Text = ">>> http://epicm.org/ <<<";
            }
        }

        private void txt_about_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_about_Load(object sender, EventArgs e)
        {

        }
    }
}
