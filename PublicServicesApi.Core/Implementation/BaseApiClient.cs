using Newtonsoft.Json;
using PublicServicesApi.Core.Exceptions;
using PublicServicesApi.Core.Interfaces.ApiClient;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace PublicServicesApi.Core.Implementation
{
    public abstract class BaseApiClient<TRequest, TResponse> : IApiClient<TRequest, TResponse>
    {
        public async Task<TResponse> ExecuteAsync(string resource, Method method, TRequest model)
        {
            using (var client = new RestClient())
            {
                var request = new RestRequest(resource, method);
                SetRequestParams(request, model);
                var response = await client.ExecuteAsync(request);
                return ResponseHandler(response);
            }
        }
        protected virtual void SetRequestParams(RestRequest request, TRequest model) { }

        protected virtual TResponse ResponseHandler(RestResponse response)
        {

            var okStatus = new List<HttpStatusCode> { HttpStatusCode.OK };

            if (response == null) 
            {
                throw new ApiServiceException($"Something went wrong! Response is null");
            }

            if (!okStatus.Contains(response.StatusCode))
            {
                ExceptionHandling(response);
                throw new ApiServiceException($"Something went wrong! Take look to status code: {response.StatusCode}");
            }

            return JsonConvert.DeserializeObject<TResponse>(response.Content);
        }

        protected virtual void ExceptionHandling(RestResponse response) { }
    }
}
