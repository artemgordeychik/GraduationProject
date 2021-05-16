using Newtonsoft.Json.Linq;

namespace TestingFramework.Framework.Utils
{
    public static class JsonUttils
    {
        public static string GetKeyData(string jsonString, string key) => JObject.Parse(jsonString)[key].ToString();
    }
}
