using PublicServicesApi.Core.Interfaces.Providers;
using PublicServicesApi.Core.Interfaces.Services;
using PublicServicesApi.Core.Models.Request;
using PublicServicesApi.Core.Models.Response;
using System.Threading.Tasks;

namespace PublicServicesApi.Service.Services
{
    public class PublicServicesService : IPublicServicesService
    {
        private readonly IApiServicesProvider _apiServicesProvider;
        public PublicServicesService(IApiServicesProvider apiServicesProvider)
        {
            _apiServicesProvider = apiServicesProvider;
        }

        public Task<SearchInfoResponse> GetServiceInfoAsync(SearchRequest request)
        {
           return _apiServicesProvider.GetServiceInfoAsync(request);
        }
    }
}
