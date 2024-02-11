using Microsoft.Extensions.Options;
using PublicServicesApi.Core.Implementation;
using PublicServicesApi.Core.Interfaces.Providers;
using PublicServicesApi.Core.Models.Configuration;
using PublicServicesApi.Core.Models.Request;
using PublicServicesApi.Core.Models.Response;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PublicServicesApi.Core.Exceptions;

namespace PublicServicesApi.Provider.ApiProviders
{
    public class ApiServicesProvider: PublicServiceApiClientProvider<SearchRequest, SearchInfoResponse>, IApiServicesProvider
    {

        private readonly ApiServicesConfiguration _configuration;
        public ApiServicesProvider(IOptions<ApiServicesConfiguration> configuration)
        {
            _configuration = configuration?.Value;
        }
        public async Task<SearchInfoResponse> GetServiceInfoAsync(SearchRequest request)
        {
            return await ExecuteAsync(_configuration.PublicService.SearchFlatInfoService.Resource, _configuration.PublicService.SearchFlatInfoService.Method,request);
        }

        protected override void SetRequestParams(RestRequest request, SearchRequest model)
        {
            base.SetRequestParams(request, model);

            request.AddParameter("pageIndex", model.PageIndex, ParameterType.QueryString);
            request.AddParameter("elementsPerPage", model.ElementsPerPage, ParameterType.QueryString);
            request.AddBody(model.FlatInfo, ContentType.Json);
        }
        protected override void ExceptionHandling(RestResponse response)
        {
            if (response.StatusCode == 0)
                throw new ApiServiceException(response?.Content ?? $"Don't have contents {_configuration?.PublicService?.SearchFlatInfoService?.Resource}");
        }
    }
}
