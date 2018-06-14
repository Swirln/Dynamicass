using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Drawing;

namespace Dynamicass
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (path.Contains("10"))
                SharedResources.version = 2010;
            else if (path.Contains("08"))
                SharedResources.version = 2008;
            else
            {
                MessageBox.Show("Invalid version!!!", "Dynamicass");
                Environment.Exit(0);
            }
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(new NobeliumUserLogin());
        }
    }
}
