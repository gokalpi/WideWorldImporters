using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace WideWorldImporters.Application.Responses
{
    public class PagedResponse<T> : ListResponse<T>, IPagedResponse<T>
    {
        public PagedResponse()
        {
        }

        public PagedResponse(IEnumerable<T> model) : base(model)
        {
        }

        public PagedResponse(ILogger logger, string actionName, Exception ex) : base(logger, actionName, ex)
        {
        }

        public PagedResponse(ILogger logger, string actionName, string message) : base(logger, actionName, message)
        {
        }

        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        public int TotalItems { get; set; }

        public int PageCount
            => TotalItems < PageSize ? 1 : (int)(((double)TotalItems / PageSize) + 1);
    }
}