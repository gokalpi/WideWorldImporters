using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace WideWorldImporters.Application.Responses
{
    public class ListResponse<T> : Response, IListResponse<T>
    {
        public ListResponse()
        {
        }

        public ListResponse(IEnumerable<T> model)
        {
            IsSuccessful = true;
            Message = default;
            Model = model;
        }

        public ListResponse(ILogger logger, string actionName, Exception ex) : base(logger, actionName, ex)
        {
        }

        public ListResponse(ILogger logger, string actionName, string message) : base(logger, actionName, message)
        {
        }

        public IEnumerable<T> Model { get; set; }
    }
}