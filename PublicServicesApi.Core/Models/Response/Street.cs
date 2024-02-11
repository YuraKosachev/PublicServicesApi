using Newtonsoft.Json;

namespace PublicServicesApi.Core.Models.Response
{
    public class Street
    {
        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("actual")]
        public bool Actual { get; set; }

        [JsonProperty("code")]
        public object Code { get; set; }

        [JsonProperty("rootEntityGuid")]
        public object RootEntityGuid { get; set; }

        [JsonProperty("lastUpdateDate")]
        public object LastUpdateDate { get; set; }

        [JsonProperty("createDate")]
        public object CreateDate { get; set; }

        [JsonProperty("aoGuid")]
        public string AoGuid { get; set; }

        [JsonProperty("aoLevel")]
        public int AoLevel { get; set; }

        [JsonProperty("postalCode")]
        public object PostalCode { get; set; }

        [JsonProperty("formalName")]
        public string FormalName { get; set; }

        [JsonProperty("offName")]
        public string OffName { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("parentGuid")]
        public string ParentGuid { get; set; }

        [JsonProperty("oktmo")]
        public object Oktmo { get; set; }

        [JsonProperty("regionCode")]
        public string RegionCode { get; set; }

        [JsonProperty("autoCode")]
        public object AutoCode { get; set; }

        [JsonProperty("areaCode")]
        public object AreaCode { get; set; }

        [JsonProperty("cityCode")]
        public object CityCode { get; set; }

        [JsonProperty("ctarCode")]
        public object CtarCode { get; set; }

        [JsonProperty("placeCode")]
        public object PlaceCode { get; set; }

        [JsonProperty("planCode")]
        public object PlanCode { get; set; }

        [JsonProperty("streetCode")]
        public object StreetCode { get; set; }

        [JsonProperty("extrCode")]
        public object ExtrCode { get; set; }

        [JsonProperty("sextCode")]
        public object SextCode { get; set; }

        [JsonProperty("updateDate")]
        public object UpdateDate { get; set; }

        [JsonProperty("isAddedManually")]
        public object IsAddedManually { get; set; }

        [JsonProperty("onApproval")]
        public object OnApproval { get; set; }

        [JsonProperty("fiasAddrobjGuid")]
        public object FiasAddrobjGuid { get; set; }

        [JsonProperty("subjectCity")]
        public bool SubjectCity { get; set; }
    }
}