using System.Threading.Tasks;
using WideWorldImporters.Application.Responses;
using WideWorldImporters.Core.Entities.Puchasing;

namespace WideWorldImporters.Application.Interfaces
{
    public interface IPurchasingService : IService
    {
        Task<ISingleResponse<PurchaseOrder>> CreatePurchaseOrderAsync(PurchaseOrder entity);

        Task<ISingleResponse<PurchaseOrderLine>> CreatePurchaseOrderLineAsync(PurchaseOrderLine entity);

        Task<ISingleResponse<Supplier>> CreateSupplierAsync(Supplier entity);

        Task<ISingleResponse<SupplierCategory>> CreateSupplierCategoryAsync(SupplierCategory entity);

        Task<ISingleResponse<SupplierTransaction>> CreateSupplierTransactionAsync(SupplierTransaction entity);

        Task<IResponse> DeletePurchaseOrderAsync(int id);

        Task<IResponse> DeletePurchaseOrderLineAsync(int id);

        Task<IResponse> DeleteSupplierAsync(int id);

        Task<IResponse> DeleteSupplierCategoryAsync(int id);

        Task<IResponse> DeleteSupplierTransactionAsync(int id);

        Task<ISingleResponse<PurchaseOrder>> GetPurchaseOrderAsync(int id);

        Task<ISingleResponse<PurchaseOrderLine>> GetPurchaseOrderLineAsync(int id);

        Task<IPagedResponse<PurchaseOrderLine>> GetPurchaseOrderLinesAsync(int pageSize = 10, int pageNumber = 1, int? purchaseOrderId = null, int? stockItemId = null, int? packageTypeId = null);

        Task<IPagedResponse<PurchaseOrder>> GetPurchaseOrdersAsync(int pageSize = 10, int pageNumber = 1, int? supplierId = null, int? deliveryMethodId = null, int? contactPersonId = null);

        Task<ISingleResponse<Supplier>> GetSupplierAsync(int id);

        Task<IPagedResponse<SupplierCategory>> GetSupplierCategoriesAsync(int pageSize = 10, int pageNumber = 1);

        Task<ISingleResponse<SupplierCategory>> GetSupplierCategoryAsync(int id);

        Task<IPagedResponse<Supplier>> GetSuppliersAsync(int pageSize = 10, int pageNumber = 1, int? supplierCategoryId = null, int? primaryContactPersonId = null, int? alternateContactPersonId = null, int? deliveryCityId = null, int? postalCityId = null);

        Task<ISingleResponse<SupplierTransaction>> GetSupplierTransactionAsync(int id);

        Task<IPagedResponse<SupplierTransaction>> GetSupplierTransactionsAsync(int pageSize = 10, int pageNumber = 1, int? supplierId = null, int? transactionTypeId = null, int? purchaseOrderId = null, int? paymentMethodId = null);

        Task<IResponse> UpdatePurchaseOrderAsync(PurchaseOrder entity);

        Task<IResponse> UpdatePurchaseOrderLineAsync(PurchaseOrderLine entity);

        Task<IResponse> UpdateSupplierAsync(Supplier entity);

        Task<IResponse> UpdateSupplierCategoryAsync(SupplierCategory entity);

        Task<IResponse> UpdateSupplierTransactionAsync(SupplierTransaction entity);
    }
}