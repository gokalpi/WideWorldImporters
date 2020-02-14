namespace WideWorldImporters.Application.Responses
{
    public interface IPagedResponse<T> : IListResponse<T>
    {
        int TotalItems { get; set; }

        int PageCount { get; }
    }
}