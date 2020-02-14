namespace WideWorldImporters.Application.Responses
{
    public class SingleResponse<T> : ISingleResponse<T>
    {
        public SingleResponse()
        {
        }

        public SingleResponse(string message)
        {
            IsSuccessful = false;
            Message = message;
            Model = default;
        }

        public SingleResponse(T model)
        {
            IsSuccessful = true;
            Message = default;
            Model = model;
        }

        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public T Model { get; set; }
    }
}