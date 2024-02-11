using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace PublicServicesApi.Core.Models.Response
{
    public class Address
    {
        [JsonProperty("region")]
        public Region Region { get; set; }

        [JsonProperty("area")]
        public object Area { get; set; }

        [JsonProperty("city")]
        public object City { get; set; }

        [JsonProperty("ctar")]
        public object Ctar { get; set; }

        [JsonProperty("additionalTerritory")]
        public object AdditionalTerritory { get; set; }

        [JsonProperty("additionalTerStreet")]
        public object AdditionalTerStreet { get; set; }

        [JsonProperty("settlement")]
        public object Settlement { get; set; }

        [JsonProperty("planningStructureElement")]
        public object PlanningStructureElement { get; set; }

        [JsonProperty("street")]
        public Street Street { get; set; }

        [JsonProperty("house")]
        public House House { get; set; }

        [JsonProperty("formattedAddress")]
        public string FormattedAddress { get; set; }

        [JsonProperty("deprecated")]
        public bool? Deprecated { get; set; }
    }
}