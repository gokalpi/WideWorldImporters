using Microsoft.Extensions.Logging;
using System;

namespace WideWorldImporters.Application.Responses
{
    public class SingleResponse<T> : Response, ISingleResponse<T>
    {
        public SingleResponse()
        {
        }

        public SingleResponse(T model)
        {
            IsSuccessful = true;
            Message = default;
            Model = model;
        }

        public SingleResponse(ILogger logger, string actionName, Exception ex) : base(logger, actionName, ex)
        {
        }

        public SingleResponse(ILogger logger, string actionName, string message) : base(logger, actionName, message)
        {
        }

        public T Model { get; set; }
    }
}