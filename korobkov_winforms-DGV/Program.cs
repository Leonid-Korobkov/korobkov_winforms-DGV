using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGV.Standart.Manager;
using DGV.Standart.Storage;

namespace korobkov_winforms_DGV
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var storage = new MemoryTourStorage();
            var manager = new TourManager(storage);

            Application.Run(new MainForm(manager));
        }
    }
}
