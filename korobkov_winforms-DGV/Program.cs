using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGV.Standart.Manager;
using DGV.Standart.Storage;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Extensions.Logging;

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

            // serilog
            var serilogLogger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.Seq("http://localhost:5341/", apiKey: "mudhnSNLQJrgaLSZPuuw")
                .CreateLogger();
            ;
            var logger = new SerilogLoggerFactory(serilogLogger)
                .CreateLogger("winforms-dgv");

            // default logget
            /*var factory = LoggerFactory.Create(buelder => buelder.AddDebug());
            var logger = factory.CreateLogger(nameof(DataGrid));*/

            var storage = new MemoryTourStorage();
            var manager = new TourManager(storage, logger);

            Application.Run(new MainForm(manager));
        }
    }
}
