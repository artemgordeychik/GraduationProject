using Newtonsoft.Json.Linq;
using System;

namespace TestingFramework.Framework.Resources
{
    public class ConfigurationsWorker
    {
        public static string getConfigProperties(string key)
        {
            return getSpecificProperties("\\TestingFramework\\Resources\\Settings.json", key);
        }

        private static string getSpecificProperties(string propertyPath, string key)
        {
            JObject jsonObject = JObject.Parse(System.IO.File.ReadAllText(Environment.CurrentDirectory + propertyPath));
            string jsonString = jsonObject.ToString(Newtonsoft.Json.Formatting.None);
            return JObject.Parse(jsonString)[key].ToString();
        }
    }
}
