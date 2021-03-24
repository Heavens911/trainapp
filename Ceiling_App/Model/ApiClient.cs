using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Ceiling_App.Model
{
    class ApiClient
    {
        private const string apiURL = "https://localhost:44326/";

        public List<Client> GetClients()
        {
            return SendRequest<List<Client>>("Clients", "GET");
        }
            


        private TResponse SendRequest<TResponse>(string path, string method)
        {
            var request = (HttpWebRequest)WebRequest.Create($"{apiURL}{path}");

            request.Method = method;
            if (method == "PUT" || method == "POST") request.ContentType = "aplication/json";

            var response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode != HttpStatusCode.OK) throw new Exception("Бла бла бла не 200 короче");
            string responseBody = string.Empty;

            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    responseBody = reader.ReadToEnd();
                }
            }

            response.Close();
            return JsonConvert.DeserializeObject<TResponse>(responseBody);
        }
    }
}
