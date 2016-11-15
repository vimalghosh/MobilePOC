using Newtonsoft.Json;

namespace SanManuelMobile.Core.Models
{
    public class LoginToken:BaseModel
    {
        [JsonProperty(".expires")]
        public string Expires { get; set; }
        [JsonProperty(".issued")]
        public string Issued { get; set; }
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("expires")]
        public string ExpiresIn { get; set; }
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
        [JsonProperty("userName")]
        public string UserName { get; set; }
    }
}