using log4net;
using System;
using System.Collections.Generic;
using System.Text;

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
            Logger.Log.Info(numberOfStep + " - " + step);
        }

        public static void MakeLog(string log)
        {
            Logger.Log.Info(log);
        }

        public static void MakeErrorLog(string message)
        {
            string customLog = "Error: " + message;
            Logger.Log.Info(customLog);
            throw new System.Exception();
        }
    }
}
