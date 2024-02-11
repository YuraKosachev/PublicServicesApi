using RestSharp;

namespace PublicServicesApi.Core.Models.Configuration
{
    public abstract class ConfigurationBase
    {
        public string Resource { get; set; }
        public Method Method { get; set; }
    }
}
