using System.Collections.Generic;
using Newtonsoft.Json;

namespace PublicServicesApi.Core.Models.Errors
{
    public class ErrorList
    {
        [JsonProperty("errors")]
        public IList<Error> Errors { get; set; }
    }
}