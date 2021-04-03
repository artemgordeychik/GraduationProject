using log4net;
using log4net.Config;

namespace TestingFramework.Framework.Utils
{
    public class Logger
    {
        public static ILog Log { get; } = LogManager.GetLogger("LOGGER");

        public static void InitLogger()
        {
            XmlConfigurator.Configure();
        }

        public static void MakeStepLog(int numberOfStep, string step)
        {
            Log.Info(numberOfStep + " - " + step);
        }

        public static void MakeLog(string log)
        {
            Log.Info(log);
        }

        public static void MakeErrorLog(string message)
        {
            string customLog = "Error: " + message;
            Log.Info(customLog);
            throw new System.Exception();
        }
    }
}
