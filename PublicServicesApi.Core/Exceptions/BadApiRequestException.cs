using PublicServicesApi.Core.Models.Errors;
using System;
using System.Collections.Generic;

namespace PublicServicesApi.Core.Exceptions
{
    public class BadApiRequestException : Exception
    {
        public List<Error> Errors { get; }

        public BadApiRequestException(List<Error> errors)
        {
            Errors = errors;
        }
    }
}