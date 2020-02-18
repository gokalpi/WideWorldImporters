using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WideWorldImporters.Application.Interfaces;
using WideWorldImporters.Application.Responses;
using WideWorldImporters.Core.Entities.Puchasing;
using WideWorldImporters.Core.Interfaces;

namespace WideWorldImporters.Application.Services
{
    public class PurchasingService : Service, IPurchasingService
    {
        public PurchasingService(ILogger<PurchasingService> logger, IUnitOfWork unitOfWork)
            : base(logger, unitOfWork)
        {
        }

        public async Task<ISingleResponse<PurchaseOrder>> CreatePurchaseOrderAsync(PurchaseOrder entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreatePurchaseOrderAsync));

            try
            {
                UnitOfWork.Repository<PurchaseOrder>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<PurchaseOrder>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<PurchaseOrder>(Logger, nameof(CreatePurchaseOrderAsync), ex);
            }
        }

        public async Task<ISingleResponse<PurchaseOrderLine>> CreatePurchaseOrderLineAsync(PurchaseOrderLine entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreatePurchaseOrderLineAsync));

            try
            {
                UnitOfWork.Repository<PurchaseOrderLine>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<PurchaseOrderLine>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<PurchaseOrderLine>(Logger, nameof(CreatePurchaseOrderLineAsync), ex);
            }
        }

        public async Task<ISingleResponse<Supplier>> CreateSupplierAsync(Supplier entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateSupplierAsync));

            try
            {
                UnitOfWork.Repository<Supplier>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<Supplier>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Supplier>(Logger, nameof(CreateSupplierAsync), ex);
            }
        }

        public async Task<ISingleResponse<SupplierCategory>> CreateSupplierCategoryAsync(SupplierCategory entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateSupplierCategoryAsync));

            try
            {
                UnitOfWork.Repository<SupplierCategory>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<SupplierCategory>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<SupplierCategory>(Logger, nameof(CreateSupplierCategoryAsync), ex);
            }
        }

        public async Task<ISingleResponse<SupplierTransaction>> CreateSupplierTransactionAsync(SupplierTransaction entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateSupplierTransactionAsync));

            try
            {
                UnitOfWork.Repository<SupplierTransaction>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<SupplierTransaction>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<SupplierTransaction>(Logger, nameof(CreateSupplierTransactionAsync), ex);
            }
        }

        public async Task<IResponse> DeletePurchaseOrderAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeletePurchaseOrderAsync));

            try
            {
                var entity = UnitOfWork.Repository<PurchaseOrder>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeletePurchaseOrderAsync), $"PurchaseOrder with id {id} not found");

                UnitOfWork.Repository<PurchaseOrder>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeletePurchaseOrderAsync), ex);
            }
        }

        public async Task<IResponse> DeletePurchaseOrderLineAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeletePurchaseOrderLineAsync));

            try
            {
                var entity = UnitOfWork.Repository<PurchaseOrderLine>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeletePurchaseOrderLineAsync), $"PurchaseOrderLine with id {id} not found");

                UnitOfWork.Repository<PurchaseOrderLine>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeletePurchaseOrderLineAsync), ex);
            }
        }

        public async Task<IResponse> DeleteSupplierAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteSupplierAsync));

            try
            {
                var entity = UnitOfWork.Repository<Supplier>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteSupplierAsync), $"Supplier with id {id} not found");

                UnitOfWork.Repository<Supplier>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteSupplierAsync), ex);
            }
        }

        public async Task<IResponse> DeleteSupplierCategoryAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteSupplierCategoryAsync));

            try
            {
                var entity = UnitOfWork.Repository<SupplierCategory>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteSupplierCategoryAsync), $"SupplierCategory with id {id} not found");

                UnitOfWork.Repository<SupplierCategory>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteSupplierCategoryAsync), ex);
            }
        }

        public async Task<IResponse> DeleteSupplierTransactionAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteSupplierTransactionAsync));

            try
            {
                var entity = UnitOfWork.Repository<SupplierTransaction>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteSupplierTransactionAsync), $"SupplierTransaction with id {id} not found");

                UnitOfWork.Repository<SupplierTransaction>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteSupplierTransactionAsync), ex);
            }
        }

        public async Task<IPagedResponse<PurchaseOrder>> GetPurchaseOrdersAsync(int pageSize = 10, int pageNumber = 1, int? supplierId = null, int? deliveryMethodId = null, int? contactPersonId = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetPurchaseOrdersAsync));

            var response = new PagedResponse<PurchaseOrder>();

            try
            {
                Expression<Func<PurchaseOrder, bool>> predicate = p => true;

                if (supplierId.HasValue)
                    predicate = predicate.And(p => p.SupplierId == supplierId);

                if (deliveryMethodId.HasValue)
                    predicate = predicate.And(p => p.DeliveryMethodId == deliveryMethodId);

                if (contactPersonId.HasValue)
                    predicate = predicate.And(p => p.ContactPersonId == contactPersonId);

                response.Model = await UnitOfWork.Repository<PurchaseOrder>().GetAsync(predicate, includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<PurchaseOrder>(Logger, nameof(GetPurchaseOrdersAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<PurchaseOrder>> GetPurchaseOrderAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetPurchaseOrderAsync));

            var response = new SingleResponse<PurchaseOrder>();

            try
            {
                return new SingleResponse<PurchaseOrder>(await UnitOfWork.Repository<PurchaseOrder>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<PurchaseOrder>(Logger, nameof(GetPurchaseOrderAsync), ex);
            }
        }

        public async Task<IPagedResponse<PurchaseOrderLine>> GetPurchaseOrderLinesAsync(int pageSize = 10, int pageNumber = 1, int? purchaseOrderId = null, int? stockItemId = null, int? packageTypeId = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetPurchaseOrderLinesAsync));

            var response = new PagedResponse<PurchaseOrderLine>();

            try
            {
                Expression<Func<PurchaseOrderLine, bool>> predicate = p => true;

                if (purchaseOrderId.HasValue)
                    predicate = predicate.And(p => p.PurchaseOrderId == purchaseOrderId);

                if (stockItemId.HasValue)
                    predicate = predicate.And(p => p.StockItemId == stockItemId);

                if (packageTypeId.HasValue)
                    predicate = predicate.And(p => p.PackageTypeId == packageTypeId);

                response.Model = await UnitOfWork.Repository<PurchaseOrderLine>().GetAsync(predicate, includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<PurchaseOrderLine>(Logger, nameof(GetPurchaseOrderLinesAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<PurchaseOrderLine>> GetPurchaseOrderLineAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetPurchaseOrderLineAsync));

            var response = new SingleResponse<PurchaseOrderLine>();

            try
            {
                return new SingleResponse<PurchaseOrderLine>(await UnitOfWork.Repository<PurchaseOrderLine>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<PurchaseOrderLine>(Logger, nameof(GetPurchaseOrderLineAsync), ex);
            }
        }

        public async Task<ISingleResponse<Supplier>> GetSupplierAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetSupplierAsync));

            var response = new SingleResponse<Supplier>();

            try
            {
                return new SingleResponse<Supplier>(await UnitOfWork.Repository<Supplier>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<Supplier>(Logger, nameof(GetSupplierAsync), ex);
            }
        }

        public async Task<IPagedResponse<Supplier>> GetSuppliersAsync(int pageSize = 10, int pageNumber = 1, int? supplierCategoryId = null, int? primaryContactPersonId = null, int? alternateContactPersonId = null, int? deliveryCityId = null, int? postalCityId = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetSuppliersAsync));

            var response = new PagedResponse<Supplier>();

            try
            {
                Expression<Func<Supplier, bool>> predicate = p => true;

                if (supplierCategoryId.HasValue)
                    predicate = predicate.And(p => p.SupplierCategoryId == supplierCategoryId);

                if (primaryContactPersonId.HasValue)
                    predicate = predicate.And(p => p.PrimaryContactPersonId == primaryContactPersonId);

                if (alternateContactPersonId.HasValue)
                    predicate = predicate.And(p => p.AlternateContactPersonId == alternateContactPersonId);

                if (deliveryCityId.HasValue)
                    predicate = predicate.And(p => p.DeliveryCityId == deliveryCityId);

                if (postalCityId.HasValue)
                    predicate = predicate.And(p => p.PostalCityId == postalCityId);

                response.Model = await UnitOfWork.Repository<Supplier>().GetAsync(predicate, includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<Supplier>(Logger, nameof(GetSuppliersAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<SupplierCategory>> GetSupplierCategoryAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetSupplierCategoryAsync));

            var response = new SingleResponse<SupplierCategory>();

            try
            {
                return new SingleResponse<SupplierCategory>(await UnitOfWork.Repository<SupplierCategory>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<SupplierCategory>(Logger, nameof(GetSupplierCategoryAsync), ex);
            }
        }

        public async Task<IPagedResponse<SupplierCategory>> GetSupplierCategoriesAsync(int pageSize = 10, int pageNumber = 1)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetSupplierCategoriesAsync));

            var response = new PagedResponse<SupplierCategory>();

            try
            {
                response.Model = await UnitOfWork.Repository<SupplierCategory>().GetAsync(p => true, includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<SupplierCategory>(Logger, nameof(GetSupplierCategoriesAsync), ex);
            }

            return response;
        }

        public async Task<IPagedResponse<SupplierTransaction>> GetSupplierTransactionsAsync(int pageSize = 10, int pageNumber = 1, int? supplierId = null, int? transactionTypeId = null, int? purchaseOrderId = null, int? paymentMethodId = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetSupplierTransactionsAsync));

            var response = new PagedResponse<SupplierTransaction>();

            try
            {
                Expression<Func<SupplierTransaction, bool>> predicate = p => true;

                if (supplierId.HasValue)
                    predicate = predicate.And(p => p.SupplierId == supplierId);

                if (transactionTypeId.HasValue)
                    predicate = predicate.And(p => p.TransactionTypeId == transactionTypeId);

                if (purchaseOrderId.HasValue)
                    predicate = predicate.And(p => p.PurchaseOrderId == purchaseOrderId);

                if (paymentMethodId.HasValue)
                    predicate = predicate.And(p => p.PaymentMethodId == paymentMethodId);

                response.Model = await UnitOfWork.Repository<SupplierTransaction>().GetAsync(predicate, includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<SupplierTransaction>(Logger, nameof(GetSupplierTransactionsAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<SupplierTransaction>> GetSupplierTransactionAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetSupplierTransactionAsync));

            var response = new SingleResponse<SupplierTransaction>();

            try
            {
                return new SingleResponse<SupplierTransaction>(await UnitOfWork.Repository<SupplierTransaction>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<SupplierTransaction>(Logger, nameof(GetSupplierTransactionAsync), ex);
            }
        }

        public async Task<IResponse> UpdatePurchaseOrderAsync(PurchaseOrder entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdatePurchaseOrderAsync));

            try
            {
                UnitOfWork.Repository<PurchaseOrder>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdatePurchaseOrderAsync), ex);
            }
        }

        public async Task<IResponse> UpdatePurchaseOrderLineAsync(PurchaseOrderLine entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdatePurchaseOrderLineAsync));

            try
            {
                UnitOfWork.Repository<PurchaseOrderLine>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdatePurchaseOrderLineAsync), ex);
            }
        }

        public async Task<IResponse> UpdateSupplierAsync(Supplier entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateSupplierAsync));

            try
            {
                UnitOfWork.Repository<Supplier>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateSupplierAsync), ex);
            }
        }

        public async Task<IResponse> UpdateSupplierCategoryAsync(SupplierCategory entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateSupplierCategoryAsync));

            try
            {
                UnitOfWork.Repository<SupplierCategory>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateSupplierCategoryAsync), ex);
            }
        }

        public async Task<IResponse> UpdateSupplierTransactionAsync(SupplierTransaction entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateSupplierTransactionAsync));

            try
            {
                UnitOfWork.Repository<SupplierTransaction>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateSupplierTransactionAsync), ex);
            }
        }
    }
}