using SanManuelMobile.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanManuelMobile.Core.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using SanManuelMobile.Core.Contracts.Services;

namespace SanManuelMobile.Core.Services
{
    public class LoginService : ILoginService
    {

        private HttpClient client;

        public async Task<LoginToken> Login(string userName, string password)
        {
            LoginToken loginToken = null;
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Accept.Clear();
            // client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var urlEncodedData = string.Format("userName={0}&password={1}&grant_type=password", userName, password);
            HttpContent payload = new StringContent(urlEncodedData, Encoding.UTF8, "application/x-www-form-urlencoded");
                     
            var uri = new Uri(string.Format(Constants.LoginURI, string.Empty));
           
            var response = await client.PostAsync(uri,payload);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                loginToken = JsonConvert.DeserializeObject<LoginToken>(content);
            }
            return loginToken;
        }
    }
}
