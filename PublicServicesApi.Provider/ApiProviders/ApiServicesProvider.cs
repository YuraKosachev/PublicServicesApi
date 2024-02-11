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

            //request.AddHeader("Content-Type", "application/json");

            request.AddParameter("pageIndex", model.PageIndex, ParameterType.QueryString);
            request.AddParameter("elementsPerPage", model.ElementsPerPage, ParameterType.QueryString);
            //var json = JsonConvert.SerializeObject(model.FlatInfo);
            request.AddBody(model.FlatInfo, ContentType.Json);//.AddParameter("data", json, ParameterType.RequestBody);
        }
    }
}
