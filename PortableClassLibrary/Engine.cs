using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PortableClassLibrary
{
    public class Engine
    {
        public Engine()
        {

        }

        public async Task<string> DownloadFeed()
        {
            var httpClient = new HttpClient();
            try
            {
                var url = "http://alerts.weather.gov/cap/us.php?x=0";
                HttpResponseMessage response = await httpClient.GetAsync(url);
                return response.StatusCode.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
