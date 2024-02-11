using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace PublicServicesApi.Core.Models.Response
{
    public class House
    {
        [JsonProperty("guid")]
        public Guid? Guid { get; set; }

        [JsonProperty("actual")]
        public bool? Actual { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("rootEntityGuid")]
        public Guid? RootEntityGuid { get; set; }

        [JsonProperty("lastUpdateDate")]
        public DateTime? LastUpdateDate { get; set; }

        [JsonProperty("createDate")]
        public DateTime? CreateDate { get; set; }

        [JsonProperty("houseGuid")]
        public Guid? HouseGuid { get; set; }

        [JsonProperty("aoGuid")]
        public Guid? AoGuid { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("houseNumber")]
        public string HouseNumber { get; set; }

        [JsonProperty("buildingNumber")]
        public string BuildingNumber { get; set; }

        [JsonProperty("structNumber")]
        public object StructNumber { get; set; }

        [JsonProperty("additionalName")]
        public string AdditionalName { get; set; }

        [JsonProperty("houseCondition")]
        public object HouseCondition { get; set; }

        [JsonProperty("propertyStateGuid")]
        public object PropertyStateGuid { get; set; }

        [JsonProperty("oktmo")]
        public object Oktmo { get; set; }

        [JsonProperty("formattedAddress")]
        public object FormattedAddress { get; set; }

        [JsonProperty("isAddedManually")]
        public bool? IsAddedManually { get; set; }

        [JsonProperty("onApproval")]
        public object OnApproval { get; set; }

        [JsonProperty("estStatus")]
        public string EstStatus { get; set; }

        [JsonProperty("strStatus")]
        public string StrStatus { get; set; }

        [JsonProperty("fiasHouseGuid")]
        public Guid? FiasHouseGuid { get; set; }

        [JsonProperty("aggregated")]
        public bool? Aggregated { get; set; }

        [JsonProperty("childAddresses")]
        public object ChildAddresses { get; set; }

        [JsonProperty("parentAggregatedGuid")]
        public Guid? ParentAggregatedGuid { get; set; }

        [JsonProperty("houseTextAddress")]
        public string HouseTextAddress { get; set; }

        [JsonProperty("doubles")]
        public object Doubles { get; set; }

        [JsonProperty("actualHouseGuid")]
        public object ActualHouseGuid { get; set; }

        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }
    }
}