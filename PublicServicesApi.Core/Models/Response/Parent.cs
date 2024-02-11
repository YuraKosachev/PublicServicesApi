using Newtonsoft.Json;

namespace PublicServicesApi.Core.Models.Response
{
    public class Parent
    {
        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("actual")]
        public bool Actual { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("rootEntityGuid")]
        public object RootEntityGuid { get; set; }

        [JsonProperty("lastUpdateDate")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("controlNumber")]
        public int ControlNumber { get; set; }

        [JsonProperty("additionalData")]
        public object AdditionalData { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("parent")]
        public Parent Parentt { get; set; }

        [JsonProperty("status")]
        public object Status { get; set; }

        [JsonProperty("utvDate")]
        public string UtvDate { get; set; }

        [JsonProperty("vvedDate")]
        public string VvedDate { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("hasChildren")]
        public bool HasChildren { get; set; }

        [JsonProperty("hasActualChildren")]
        public bool HasActualChildren { get; set; }

        [JsonProperty("loadAttribute")]
        public object LoadAttribute { get; set; }

        [JsonProperty("oldMoscow")]
        public object OldMoscow { get; set; }
    }
}