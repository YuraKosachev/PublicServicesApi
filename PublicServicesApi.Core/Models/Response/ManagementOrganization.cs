using Newtonsoft.Json;

namespace PublicServicesApi.Core.Models.Response
{
    public class ManagementOrganization
    {
        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("lastEventDate")]
        public string LastEventDate { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("orgAddress")]
        public string OrgAddress { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("organizationType")]
        public string OrganizationType { get; set; }

        [JsonProperty("olsonTZ")]
        public OlsonTZ OlsonTZ { get; set; }

        [JsonProperty("okopf")]
        public Okopf Okopf { get; set; }

        [JsonProperty("registryOrganizationRootEntityGuid")]
        public string RegistryOrganizationRootEntityGuid { get; set; }

        [JsonProperty("parentGuid")]
        public object ParentGuid { get; set; }

        [JsonProperty("ogrn")]
        public string Ogrn { get; set; }
    }
}