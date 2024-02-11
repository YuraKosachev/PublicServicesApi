using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PublicServicesApi.Core.Interfaces.ApiClient
{
    public interface IApiClient<TRequest, TResponse>
    {
        Task<TResponse> ExecuteAsync(string resource, Method method, TRequest model);
    }
}
