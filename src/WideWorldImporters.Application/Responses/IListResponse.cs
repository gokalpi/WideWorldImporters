using System.Collections.Generic;

namespace WideWorldImporters.Application.Responses
{
    public interface IListResponse<T> : IResponse
    {
        IEnumerable<T> Model { get; set; }
    }
}