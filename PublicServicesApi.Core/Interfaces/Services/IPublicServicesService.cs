using PublicServicesApi.Core.Models.Request;
using PublicServicesApi.Core.Models.Response;
using System.Threading.Tasks;

namespace PublicServicesApi.Core.Interfaces.Services
{
    public interface IPublicServicesService
    {
        Task<SearchInfoResponse> GetServiceInfoAsync(SearchRequest request);
    }
}
