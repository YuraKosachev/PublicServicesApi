using Newtonsoft.Json;

namespace PublicServicesApi.Core.Models.Response
{
    public class Item
    {
        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("rootGuid")]
        public object RootGuid { get; set; }

        [JsonProperty("versionNumber")]
        public object VersionNumber { get; set; }

        [JsonProperty("lastUpdateUnixTime")]
        public object LastUpdateUnixTime { get; set; }

        [JsonProperty("lastUpdateDate")]
        public object LastUpdateDate { get; set; }

        [JsonProperty("createDate")]
        public object CreateDate { get; set; }

        [JsonProperty("readOnly")]
        public object ReadOnly { get; set; }

        [JsonProperty("active")]
        public object Active { get; set; }

        [JsonProperty("asyncProcessing")]
        public object AsyncProcessing { get; set; }

        [JsonProperty("asyncProcessType")]
        public object AsyncProcessType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("cancellationReasonCode")]
        public object CancellationReasonCode { get; set; }

        [JsonProperty("cancellationComment")]
        public object CancellationComment { get; set; }

        [JsonProperty("cancellationDate")]
        public object CancellationDate { get; set; }

        [JsonProperty("demolitionDate")]
        public object DemolitionDate { get; set; }

        [JsonProperty("demolitionReason")]
        public object DemolitionReason { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("houseGuid")]
        public string HouseGuid { get; set; }

        [JsonProperty("planSeries")]
        public string PlanSeries { get; set; }

        [JsonProperty("planType")]
        public object PlanType { get; set; }

        [JsonProperty("buildingYear")]
        public string BuildingYear { get; set; }

        [JsonProperty("operationYear")]
        public int? OperationYear { get; set; }

        [JsonProperty("residentialPremiseCount")]
        public string ResidentialPremiseCount { get; set; }

        [JsonProperty("nonResidentialPremiseCount")]
        public string NonResidentialPremiseCount { get; set; }

        [JsonProperty("residentialPremiseActualCount")]
        public object ResidentialPremiseActualCount { get; set; }

        [JsonProperty("nonResidentialPremiseActualCount")]
        public object NonResidentialPremiseActualCount { get; set; }

        [JsonProperty("residentialPremiseConfirmedCount")]
        public object ResidentialPremiseConfirmedCount { get; set; }

        [JsonProperty("nonResidentialPremiseConfirmedCount")]
        public object NonResidentialPremiseConfirmedCount { get; set; }

        [JsonProperty("managementOrganization")]
        public ManagementOrganization ManagementOrganization { get; set; }

        [JsonProperty("municipalityOrganization")]
        public object MunicipalityOrganization { get; set; }

        [JsonProperty("maxFloorCount")]
        public string MaxFloorCount { get; set; }

        [JsonProperty("deterioration")]
        public string Deterioration { get; set; }

        [JsonProperty("houseType")]
        public HouseType HouseType { get; set; }

        [JsonProperty("totalSquare")]
        public object TotalSquare { get; set; }

        [JsonProperty("residentialSquare")]
        public object ResidentialSquare { get; set; }

        [JsonProperty("accountCount")]
        public object AccountCount { get; set; }

        [JsonProperty("houseCondition")]
        public HouseCondition HouseCondition { get; set; }

        [JsonProperty("devices")]
        public object Devices { get; set; }

        [JsonProperty("accountRefs")]
        public object AccountRefs { get; set; }

        [JsonProperty("apartmentsWithoutAccountCount")]
        public object ApartmentsWithoutAccountCount { get; set; }

        [JsonProperty("ableEnterDeviceMetering")]
        public bool AbleEnterDeviceMetering { get; set; }

        [JsonProperty("houseManagementType")]
        public object HouseManagementType { get; set; }

        [JsonProperty("oktmo")]
        public Oktmo Oktmo { get; set; }

        [JsonProperty("canAdd")]
        public object CanAdd { get; set; }

        [JsonProperty("hasMunicipalServices")]
        public object HasMunicipalServices { get; set; }

        [JsonProperty("hasDummyShare")]
        public object HasDummyShare { get; set; }

        [JsonProperty("hasShare")]
        public object HasShare { get; set; }

        [JsonProperty("userOrganizationRole")]
        public object UserOrganizationRole { get; set; }

        [JsonProperty("blockedHouse")]
        public bool BlockedHouse { get; set; }

        [JsonProperty("cadastreNumber")]
        public string CadastreNumber { get; set; }

        [JsonProperty("oldCadastreNumber")]
        public object OldCadastreNumber { get; set; }

        [JsonProperty("canCancel")]
        public object CanCancel { get; set; }

        [JsonProperty("cancellationReason")]
        public object CancellationReason { get; set; }

        [JsonProperty("hasIncorrectObjects")]
        public object HasIncorrectObjects { get; set; }

        [JsonProperty("hasActiveDevices")]
        public object HasActiveDevices { get; set; }

        [JsonProperty("canReadShare")]
        public object CanReadShare { get; set; }

        [JsonProperty("regionProperty")]
        public object RegionProperty { get; set; }

        [JsonProperty("municipalProperty")]
        public object MunicipalProperty { get; set; }

        [JsonProperty("hostelType")]
        public object HostelType { get; set; }

        [JsonProperty("chiefFirstName")]
        public object ChiefFirstName { get; set; }

        [JsonProperty("chiefLastName")]
        public object ChiefLastName { get; set; }

        [JsonProperty("chiefMiddleName")]
        public object ChiefMiddleName { get; set; }

        [JsonProperty("houseCancelled")]
        public bool? HouseCancelled { get; set; }

        [JsonProperty("approved")]
        public bool? Approved { get; set; }

        [JsonProperty("canceledOrAsyncProcessed")]
        public bool? CanceledOrAsyncProcessed { get; set; }
    }
}