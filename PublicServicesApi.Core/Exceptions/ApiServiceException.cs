using System;

namespace PublicServicesApi.Core.Exceptions
{
    public class ApiServiceException : Exception
    {
        public ApiServiceException(string message) : base(message)
        {
        }
    }
}