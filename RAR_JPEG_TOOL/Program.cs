using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
namespace RJT
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Translation.Language = "eng";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_main());
        }
    }
    public static class Translation
    {
        public static Dictionary<string, string> Texts = new Dictionary<string, string>();
        private static string _language;
        private static void reset()
        {
            Texts.Clear();
            char[] trimchars = new char[] {'\r', ' ' };
            string[] tmpdict = Encoding.UTF8.GetString((byte[])Properties.Resources.ResourceManager.GetObject(_language)).Split('\n');
            foreach (string str in tmpdict)
            {
                string[] tmp = str.Split('=');
                Texts.Add(tmp[0].Trim().Trim(trimchars), tmp[1].Trim().Trim(trimchars));
            }
        }
        public static string Language
        {
            get
            {
                return _language;
            }
            set
            {
                if (_language != value)
                {
                    _language = value;
                    reset();
                }
            }
        }
    }
}
