using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapApp.Models.MapAppModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace MapApp.Repository
{
    public class MapAppRepository : IMapAppRepository
    {
        public MapAppResponse Getaddress(string city)
        {
            string App_ID = Configuration.Values.MappApp_ID;
            /* var client = new RestClient($"https://geocode.search.hereapi.com/v1/geocode?q={city}&apikey={App_ID}");
             var request = new RestRequest($"https://geocode.search.hereapi.com/v1/geocode?q={city}&apikey={App_ID}", Method.Get);
             IRestResponse response = (IRestResponse)client.ExecuteAsync(request);
             if (response != null) {
                 var content = JsonConvert.DeserializeObject<JToken>(response.Content);
             }*/

            var client = new RestClient($"https://geocode.search.hereapi.com/v1/geocode?q={city}&apikey={App_ID}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<JToken>(response.Content);
                return content?.ToObject<MapAppResponse>();

            }
            else
                return null;

        }
    }
}
