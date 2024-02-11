using Newtonsoft.Json;


namespace PublicServicesApi.Core.Models.Response
{
    public class HouseCondition
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

        [JsonProperty("houseCondition")]
        public string Condition { get; set; }
    }
}