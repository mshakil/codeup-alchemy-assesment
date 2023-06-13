using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharp.Authenticators;


namespace codeup_alchemy_assessment_api
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void ApiTest() 
        {
            var restClient = new RestClient("https://jsonplaceholder.typicode.com/");
            var restRequest = new RestRequest("users/", Method.Get);


            RestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            int responseCode = Convert.ToInt32(response.StatusCode);
            Assert.AreEqual(200, responseCode, "Status code is not 200");

            Assert.AreEqual("Roscoeview", RequestClient.GetToken(content), "City is not same as expected");
        }
    }
}
