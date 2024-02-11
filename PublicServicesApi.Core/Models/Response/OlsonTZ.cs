using Newtonsoft.Json;

namespace PublicServicesApi.Core.Models.Response
{
    public class OlsonTZ
    {
        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("createDate")]
        public object CreateDate { get; set; }

        [JsonProperty("lastEventDate")]
        public object LastEventDate { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }
    }
}