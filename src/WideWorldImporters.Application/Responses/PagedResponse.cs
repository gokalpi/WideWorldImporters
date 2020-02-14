using System.Collections.Generic;

namespace WideWorldImporters.Application.Responses
{
    public class PagedResponse<T> : IPagedResponse<T>
    {
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public IEnumerable<T> Model { get; set; }

        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        public int TotalItems { get; set; }

        public int PageCount
            => TotalItems < PageSize ? 1 : (int)(((double)TotalItems / PageSize) + 1);
    }
}