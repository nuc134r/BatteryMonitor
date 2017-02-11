using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryMonitor
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

            Form form1 = new Form1();
            form1.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            form1.ShowInTaskbar = false;
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = new System.Drawing.Point(-2000, -2000);
            form1.Size = new System.Drawing.Size(1, 1);

            Application.Run(form1);
        }
    }
}
