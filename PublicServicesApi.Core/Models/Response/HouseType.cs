using Newtonsoft.Json;

namespace PublicServicesApi.Core.Models.Response
{
    public class HouseType
    {
        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("actual")]
        public bool Actual { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("rootEntityGuid")]
        public string RootEntityGuid { get; set; }

        [JsonProperty("lastUpdateDate")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("houseTypeName")]
        public string HouseTypeName { get; set; }
    }
}