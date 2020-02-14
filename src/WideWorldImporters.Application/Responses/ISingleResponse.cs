namespace WideWorldImporters.Application.Responses
{
    public interface ISingleResponse<T> : IResponse
    {
        T Model { get; set; }
    }
}