using System.Threading.Tasks;
using WideWorldImporters.Application.Responses;
using WideWorldImporters.Core.Entities.Sales;

namespace WideWorldImporters.Application.Interfaces
{
    public interface ISalesService : IService
    {
        Task<ISingleResponse<BuyingGroup>> CreateBuyingGroupAsync(BuyingGroup entity);

        Task<ISingleResponse<Customer>> CreateCustomerAsync(Customer entity);

        Task<ISingleResponse<CustomerCategory>> CreateCustomerCategoryAsync(CustomerCategory entity);

        Task<ISingleResponse<CustomerTransaction>> CreateCustomerTransactionAsync(CustomerTransaction entity);

        Task<ISingleResponse<Invoice>> CreateInvoiceAsync(Invoice entity);

        Task<ISingleResponse<InvoiceLine>> CreateInvoiceLineAsync(InvoiceLine entity);

        Task<ISingleResponse<Order>> CreateOrderAsync(Order entity);

        Task<ISingleResponse<OrderLine>> CreateOrderLineAsync(OrderLine entity);

        Task<ISingleResponse<SpecialDeal>> CreateSpecialDealAsync(SpecialDeal entity);

        Task<IResponse> DeleteBuyingGroupAsync(int id);

        Task<IResponse> DeleteCustomerAsync(int id);

        Task<IResponse> DeleteCustomerCategoryAsync(int id);

        Task<IResponse> DeleteCustomerTransactionAsync(int id);

        Task<IResponse> DeleteInvoiceAsync(int id);

        Task<IResponse> DeleteInvoiceLineAsync(int id);

        Task<IResponse> DeleteOrderAsync(int id);

        Task<IResponse> DeleteOrderLineAsync(int id);

        Task<IResponse> DeleteSpecialDealAsync(int id);

        Task<ISingleResponse<BuyingGroup>> GetBuyingGroupAsync(int id);

        Task<IPagedResponse<BuyingGroup>> GetBuyingGroupsAsync(int pageSize = 10, int pageNumber = 1);

        Task<ISingleResponse<Customer>> GetCustomerAsync(int id);

        Task<IPagedResponse<CustomerCategory>> GetCustomerCategoriesAsync(int pageSize = 10, int pageNumber = 1);

        Task<ISingleResponse<CustomerCategory>> GetCustomerCategoryAsync(int id);

        Task<IPagedResponse<Customer>> GetCustomersAsync(int pageSize = 10, int pageNumber = 1, int? customerCategoryId = null, int? buyingGroupId = null);

        Task<ISingleResponse<CustomerTransaction>> GetCustomerTransactionAsync(int id);

        Task<IPagedResponse<CustomerTransaction>> GetCustomerTransactionsAsync(int pageSize = 10, int pageNumber = 1, int? customerId = null, int? transactionTypeId = null, int? invoiceId = null, int? paymentMethodId = null);

        Task<ISingleResponse<Invoice>> GetInvoiceAsync(int id);

        Task<ISingleResponse<InvoiceLine>> GetInvoiceLineAsync(int id);

        Task<IPagedResponse<InvoiceLine>> GetInvoiceLinesAsync(int? pageSize = 10, int? pageNumber = 1, int? invoiceId = null, int? stockItemId = null);

        Task<IPagedResponse<Invoice>> GetInvoicesAsync(int pageSize = 10, int pageNumber = 1, int? customerId = null, int? orderId = null);

        Task<ISingleResponse<Order>> GetOrderAsync(int id);

        Task<ISingleResponse<OrderLine>> GetOrderLineAsync(int id);

        Task<IPagedResponse<OrderLine>> GetOrderLinesAsync(int pageSize = 10, int pageNumber = 1, int? orderId = null, int? stockItemId = null);

        Task<IPagedResponse<Order>> GetOrdersAsync(int pageSize = 10, int pageNumber = 1, int? customerId = null, int? salespersonInvoiceId = null);

        Task<ISingleResponse<SpecialDeal>> GetSpecialDealAsync(int id);

        Task<IPagedResponse<SpecialDeal>> GetSpecialDealsAsync(int pageSize = 10, int pageNumber = 1, int? stockItemId = null, int? customerId = null, int? buyingGroupId = null, int? customerCategoryId = null, int? stockGroupId = null);

        Task<IResponse> UpdateBuyingGroupAsync(BuyingGroup entity);

        Task<IResponse> UpdateCustomerAsync(Customer entity);

        Task<IResponse> UpdateCustomerCategoryAsync(CustomerCategory entity);

        Task<IResponse> UpdateCustomerTransactionAsync(CustomerTransaction entity);

        Task<IResponse> UpdateInvoiceAsync(Invoice entity);

        Task<IResponse> UpdateInvoiceLineAsync(InvoiceLine entity);

        Task<IResponse> UpdateOrderAsync(Order entity);

        Task<IResponse> UpdateOrderLineAsync(OrderLine entity);

        Task<IResponse> UpdateSpecialDealAsync(SpecialDeal entity);
    }
}