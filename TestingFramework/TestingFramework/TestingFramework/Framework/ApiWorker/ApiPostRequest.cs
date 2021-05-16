using System.IO;
using unirest_net.http;

namespace TestingFramework.Framework.ApiWorker
{
    public class ApiPostRequest
    {
        public static string PostRequest(string uri, string pathToFile, string typeOfFile)
        {
            byte[] data = File.ReadAllBytes(pathToFile);
            HttpResponse<string> jsonResponse = Unirest.post(uri).field(typeOfFile, data).asJson<string>();
            return jsonResponse.Body.ToString();
        }
    }
}
