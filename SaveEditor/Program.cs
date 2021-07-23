using System;
using System.Windows.Forms;

namespace SaveEditor
{
    static class Program
    {
        public const string VERSION = "2.0.0";
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
