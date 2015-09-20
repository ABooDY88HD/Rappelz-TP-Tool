using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TP_Tool_11._2.Forms.RDB;

namespace TP_Tool_11._2
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

            Application.Run(new RDBManager());
        }
    }

}
