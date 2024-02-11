using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PublicServicesApi.Core.Models.Request
{
    public class FlatInfoRequest
    {
        [JsonProperty("regionCode")]
        public Guid? RegionCode { get; set; }

        [JsonProperty("fiasHouseCodeList")]
        public List<string> FiasHouseCodeList { get; set; }

        [JsonProperty("estStatus")]
        public object EstStatus { get; set; }

        [JsonProperty("strStatus")]
        public object StrStatus { get; set; }

        [JsonProperty("calcCount")]
        public bool CalcCount { get; set; }

        [JsonProperty("houseConditionRefList")]
        public List<string> HouseConditionRefList { get; set; }

        [JsonProperty("houseTypeRefList")]
        public List<string> HouseTypeRefList { get; set; }

        [JsonProperty("houseManagementTypeRefList")]
        public List<string> HouseManagementTypeRefList { get; set; }

        [JsonProperty("cadastreNumber")]
        public string CadastreNumber { get; set; }

        [JsonProperty("oktmo")]
        public string Oktmo { get; set; }

        [JsonProperty("statuses")]
        public List<string> Statuses { get; set; }

        [JsonProperty("regionProperty")]
        public bool? RegionProperty { get; set; }

        [JsonProperty("municipalProperty")]
        public bool? MunicipalProperty { get; set; }

        [JsonProperty("hostelTypeCodes")]
        public List<string> HostelTypeCodes { get; set; }
    }
}
