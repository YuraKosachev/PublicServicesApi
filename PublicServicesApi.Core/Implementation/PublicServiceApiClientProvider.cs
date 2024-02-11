using PublicServicesApi.Core.Exceptions;
using RestSharp;

namespace PublicServicesApi.Core.Implementation
{
    public abstract class PublicServiceApiClientProvider<TRequest, TResponse> : BaseApiClient<TRequest, TResponse>
    {
        protected override void SetRequestParams(RestRequest request, TRequest model)
        {
            request.AddParameter("Session-GUID", "046609ae-eefc-4439-b442-6b7abd9996f9", ParameterType.HttpHeader);
            request.AddParameter("Request-GUID", "195ef7a0-0c9c-4fea-9964-48c82fbf0638", ParameterType.HttpHeader);
        }

        protected override void ExceptionHandling(RestResponse response)
        {
            if(response.StatusCode == 0)
                throw new ApiServiceException(response?.Content ?? $"Don't have contents {response?.ResponseUri?.AbsoluteUri}");
        }
    }
}
