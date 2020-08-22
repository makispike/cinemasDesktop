using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cinemasDesktop.Models;
using RestSharp;

namespace cinemasDesktop
{
    class RestController
    {
        public void GetScreenings() {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://localhost:8081");
            //client.Authenticator = new OAu

            var request = new RestRequest();
            request.Resource = "screening/all";

            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

    }
}
