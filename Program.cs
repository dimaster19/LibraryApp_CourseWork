using LibraryApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;

namespace LibraryApp
{

    static class Status
    {
        public static bool Value { get; set; }
        public static bool Enter { get; set; }
        public static int ID { get; set; }
        public static bool Update { get; set; }
        public static string User { get; set; }
    }


    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
              .MinimumLevel.Information()
              .WriteTo.File("logs.log", rollingInterval: RollingInterval.Month, outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] {Message}{NewLine}{Exception}")
              .CreateLogger();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Authorization auth1 = new Authorization();

            if (auth1.ShowDialog() == DialogResult.OK && Status.Enter == true)
            {
                Application.Run(new MainForm());
            }
            Log.CloseAndFlush();
        }
    }
}
