using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PublicServicesApi.Core.Interfaces.Services;
using PublicServicesApi.Core.Models.Errors;
using PublicServicesApi.Core.Models.Request;
using PublicServicesApi.Core.Models.Response;
using System.Net;

namespace PublicServicesApi.Controllers
{
    /// <summary>
    /// Service Controller
    /// </summary>
    [Route("api")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IPublicServicesService _publicServicesService;

        /// <summary>
        /// Service Constructor
        /// </summary>
        public ServiceController(IPublicServicesService publicServicesService)
        {
            _publicServicesService = publicServicesService;
        }

        /// <summary>
        /// Get flat information
        /// </summary>
        /// <remarks>Awesomeness!</remarks>
        /// <param name="cadNumber" example="77:07:0000000:1277">Cadastral number</param>
        /// <param name="index" example="1">Page index</param>
        /// <param name="elemPerPage" example="20">Elements per page</param>
        /// <response code="200">Flat infos</response>
        /// <response code="400">Invalid or missing parameter(s)!</response>
        /// <response code="500">Oops! Can't lookup your product right now</response>
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(SearchInfoResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorList), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorList), (int)HttpStatusCode.InternalServerError)]
        [Route("service/flat/info/{cadNumber}")]
        public async Task<IActionResult> GetFlatInfoByParams(string cadNumber, int index = 1 , int elemPerPage = 10)
        {
            var flatInfo = new FlatInfoRequest();
            flatInfo.RegionCode = Guid.Parse("0c5b2444-70a0-4932-980c-b4dc0d3f02b5"); // Moskow
            flatInfo.CadastreNumber = cadNumber;
            var request = new SearchRequest(index, elemPerPage, flatInfo);

            var info = await _publicServicesService.GetServiceInfoAsync(request);
            return Ok(info);
        }
    }
}
