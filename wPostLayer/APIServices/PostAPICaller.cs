using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
namespace wPostLayer.APIServices
{
    public class PostAPICaller : IAsyncPostAPICaller
    {

        public Uri BaseAPIUri
        {
            get;
            set;
        }

        public String Accept
        {
            get;
            set;
        }

        public PostAPICaller()
        {
            this.BaseAPIUri = new Uri(ConfigurationManager.AppSettings["PostBaseAPIUri"].ToString());
            this.Accept = "application/json";
        }

        /// <summary>
        ///This method is used to call api based on relative url
        /// </summary>
        public async Task<string> Get(string url)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Accept));
                HttpResponseMessage sabreResponse = await client.GetAsync(this.BaseAPIUri + url).ConfigureAwait(false);


                if (!sabreResponse.IsSuccessStatusCode)
                {
                    return string.Empty;
                }

                var response = await sabreResponse.Content.ReadAsStringAsync();
                return response;
            }
        }
    }
    
}
