using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
//using Newtonsoft.Json;

namespace MauiApp1
{
    internal class WebsharkApi
    {
        public async void GetAPI()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://www.cheapshark.com/api/1.0/deals?storeID=1&upperPrice=15");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
        }
    }
}
