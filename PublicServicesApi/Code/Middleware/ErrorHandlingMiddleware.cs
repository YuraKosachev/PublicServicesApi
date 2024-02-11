using Newtonsoft.Json;
using PublicServicesApi.Core.Exceptions;
using PublicServicesApi.Core.Models.Errors;
using System.Net;
using System.Net.Mime;




namespace PublicServicesApi.Code.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var statusCode = HttpStatusCode.InternalServerError; // 500 if unexpected
            var errorList = new ErrorList();

            if (exception is BadApiRequestException)
            {
                statusCode = HttpStatusCode.BadRequest;
                var badRequestEx = exception as BadApiRequestException;
                errorList.Errors = badRequestEx.Errors;
            }
            else if (exception is ApiServiceException || exception is Exception)
            {
                errorList.Errors = new List<Error> { new Error { Message = exception.Message } };
            }

            var result = JsonConvert.SerializeObject(errorList);
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;
            return context.Response.WriteAsync(result);
        }
    }
}