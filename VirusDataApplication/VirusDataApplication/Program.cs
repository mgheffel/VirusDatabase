using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusDataApplication
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

            DatabaseModel dbModel = new DatabaseModel();
            Controller c = new Controller(dbModel);
            Form1 gui = new Form1(c);
            gui.ShowDialog();
            //Application.Run(gui);
        }
    }
}
