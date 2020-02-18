using Microsoft.Extensions.Logging;
using System;

namespace WideWorldImporters.Application.Responses
{
    public class Response : IResponse
    {
        public Response()
        {
        }

        public Response(ILogger logger, string actionName, Exception ex)
        {
            IsSuccessful = false;
            Message = ex.Message;
            logger?.LogError("There was an error on '{0}': {1}", actionName, ex);
        }

        public Response(ILogger logger, string actionName, string message)
        {
            IsSuccessful = false;
            Message = message;
            logger?.LogError("There was an error on '{0}': {1}", actionName, message);
        }

        public bool IsSuccessful { get; set; } = true;
        public string Message { get; set; }
    }
}