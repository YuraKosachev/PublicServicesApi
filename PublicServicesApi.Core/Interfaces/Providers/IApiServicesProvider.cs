using PublicServicesApi.Core.Models.Request;
using PublicServicesApi.Core.Models.Response;
using System.Threading.Tasks;

namespace PublicServicesApi.Core.Interfaces.Providers
{
    public interface IApiServicesProvider
    {
        Task<SearchInfoResponse> GetServiceInfoAsync(SearchRequest request);
    }
}
