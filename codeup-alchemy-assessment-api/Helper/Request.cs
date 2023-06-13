using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace codeup_alchemy_assessment_api
{
    public class RequestClient
    {
        

        public static string GetToken(string jsonString)
        {
            var json = JsonConvert.DeserializeObject(jsonString);

            var token = JToken.Parse(json.ToString()).SelectToken("[4].address.city").ToString();

            return token;

        }
    }
}
