using log4net;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerilogToLog4Net
{
    public class Program
    {
        private static ILog _file_SF_Logger;
        //   private static ILog _file_SF_Logger2;
        private static ILogger _logger;
        static void Main(string[] args)
        {
            // _file_SF_Logger = LogManager.GetLogger("File_SF_Logger");
            log4net.Config.XmlConfigurator.Configure();
            //_file_SF_Logger.Info("Log4Net created");

            Log.Logger = new LoggerConfiguration()
            .ReadFrom.AppSettings()
           .MinimumLevel.Debug()
           // .Enrich.WithProperty("SourceContext", System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.ToString())
           .WriteTo.Log4Net()
           .CreateLogger();

            _logger = Log.Logger;


            //_file_SF_Logger = LogManager.GetLogger("File_SF_Logger");
            //log4net.Config.XmlConfigurator.Configure();
            //_file_SF_Logger.Info("Log4Net created");


            _logger.Information("Serilog created");

        }
    }
}
