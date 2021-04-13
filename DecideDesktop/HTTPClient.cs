using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    static class HTTPClient
    {
        internal static HttpClient httpClient = new HttpClient();
        internal static async void GetRequest(string Address)
        {
            using (httpClient)
            {
                using (var response = await httpClient.GetAsync(Address))
                {
                    using (HttpContent SiteContent = response.Content)
                    {
                        var content = await SiteContent.ReadAsStringAsync();
                        Console.WriteLine(content);
                    }
                }
            }
        }

        internal static async void PostRequest(string Address, Dictionary<string, string> RequestData)
        {
            using (httpClient)
            {
                using (HttpContent RequestContent = new FormUrlEncodedContent(RequestData))
                {
                    using (var response = await httpClient.PostAsync(Address, RequestContent))
                    {
                        Console.WriteLine(response.Headers);
                        Console.WriteLine(response.StatusCode);
                        Console.WriteLine(response.RequestMessage);
                    }
                }         
            }
        }

        internal static async void PostRequest(string Address, string RequestData)
        {
            using (httpClient)
            {
                using (StringContent RequestContent = new StringContent(RequestData, Encoding.UTF8))
                {
                    using (var response = await httpClient.PostAsync(Address, RequestContent))
                    {
                        Console.WriteLine(response.Headers);
                        Console.WriteLine(response.StatusCode);
                        Console.WriteLine(response.RequestMessage);
                    }
                }
            }
        }
    }
}
