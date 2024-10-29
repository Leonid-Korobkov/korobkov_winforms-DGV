using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGV.Standart.Manager;
using DGV.Standart.Storage;
using Microsoft.Extensions.Logging;

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
            var factory = LoggerFactory.Create(buelder => buelder.AddDebug());
            var logger = factory.CreateLogger(nameof(DataGrid));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var storage = new MemoryTourStorage();
            var manager = new TourManager(storage, logger);

            Application.Run(new MainForm(manager));
        }
    }
}
