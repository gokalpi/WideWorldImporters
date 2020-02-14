using System.Collections.Generic;

namespace WideWorldImporters.Application.Responses
{
    public class ListResponse<T> : IListResponse<T>
    {
        public ListResponse()
        {
        }

        public ListResponse(string message)
        {
            IsSuccessful = false;
            Message = message;
            Model = default;
        }

        public ListResponse(IEnumerable<T> model)
        {
            IsSuccessful = true;
            Message = default;
            Model = model;
        }

        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public IEnumerable<T> Model { get; set; }
    }
}