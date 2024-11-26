using System;
using System.Windows.Forms;
using DGV.Standart.Manager;
using Serilog;
using Serilog.Extensions.Logging;
using DGV.Storage.Database;

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

            //var storage = new MemoryTourStorage();
            var storage = new DBTour();
            var manager = new TourManager(storage, logger);

            Application.Run(new MainForm(manager));
        }
    }
}
