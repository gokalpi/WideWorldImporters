namespace WideWorldImporters.Application.Responses
{
    public interface IResponse
    {
        bool IsSuccessful { get; set; }
        string Message { get; set; }
    }
}