using System.Collections.Generic;
using Newtonsoft.Json;

namespace PublicServicesApi.Core.Models.Response
{
    public class SearchInfoResponse
    {
        [JsonProperty("total")]
        public int? Total { get; set; }

        [JsonProperty("searchLimit")]
        public int? SearchLimit { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }
    }
}