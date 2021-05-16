using System;
using System.Collections.Generic;
using System.Text;
using unirest_net.http;

namespace TestingFramework.Framework.ApiWorker
{
    public class ApiGetRequest
    {
        public static string GetRequest(string url)
        {
            HttpResponse<string> jsonResponse = Unirest.get(url).asJson<string>();
            return jsonResponse.Body.ToString();
        }
    }
}
