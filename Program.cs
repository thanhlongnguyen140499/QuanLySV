using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFisrtCuoiKy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public class UserInfo
        {
            public string MSSV { get; set; }
            public string Name { get; set; }
            public string ID_KHOA { get; set; }
            public string name_Khoa { get; set; }
        }
    }
}
