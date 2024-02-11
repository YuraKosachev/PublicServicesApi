using Newtonsoft.Json;

namespace PublicServicesApi.Core.Models.Errors
{
    public class Error
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}