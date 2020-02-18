using Microsoft.Extensions.Logging;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WideWorldImporters.Application.Interfaces;
using WideWorldImporters.Application.Responses;
using WideWorldImporters.Core.Entities.Sales;
using WideWorldImporters.Core.Interfaces;

namespace WideWorldImporters.Application.Services
{
    public class SalesService : Service, ISalesService
    {
        public SalesService(ILogger<SalesService> logger, IUnitOfWork unitOfWork)
            : base(logger, unitOfWork)
        {
        }

        public async Task<ISingleResponse<BuyingGroup>> CreateBuyingGroupAsync(BuyingGroup entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateBuyingGroupAsync));

            try
            {
                UnitOfWork.Repository<BuyingGroup>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<BuyingGroup>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<BuyingGroup>(Logger, nameof(CreateBuyingGroupAsync), ex);
            }
        }

        public async Task<ISingleResponse<Customer>> CreateCustomerAsync(Customer entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateCustomerAsync));

            try
            {
                UnitOfWork.Repository<Customer>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<Customer>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Customer>(Logger, nameof(CreateCustomerAsync), ex);
            }
        }

        public async Task<ISingleResponse<CustomerCategory>> CreateCustomerCategoryAsync(CustomerCategory entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateCustomerCategoryAsync));

            try
            {
                UnitOfWork.Repository<CustomerCategory>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<CustomerCategory>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<CustomerCategory>(Logger, nameof(CreateCustomerCategoryAsync), ex);
            }
        }

        public async Task<ISingleResponse<CustomerTransaction>> CreateCustomerTransactionAsync(CustomerTransaction entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateCustomerTransactionAsync));

            try
            {
                UnitOfWork.Repository<CustomerTransaction>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<CustomerTransaction>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<CustomerTransaction>(Logger, nameof(CreateCustomerTransactionAsync), ex);
            }
        }

        public async Task<ISingleResponse<Invoice>> CreateInvoiceAsync(Invoice entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateInvoiceAsync));

            try
            {
                UnitOfWork.Repository<Invoice>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<Invoice>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Invoice>(Logger, nameof(CreateInvoiceAsync), ex);
            }
        }

        public async Task<ISingleResponse<InvoiceLine>> CreateInvoiceLineAsync(InvoiceLine entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateInvoiceLineAsync));

            try
            {
                UnitOfWork.Repository<InvoiceLine>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<InvoiceLine>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<InvoiceLine>(Logger, nameof(CreateInvoiceLineAsync), ex);
            }
        }

        public async Task<ISingleResponse<Order>> CreateOrderAsync(Order entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateOrderAsync));

            try
            {
                UnitOfWork.Repository<Order>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<Order>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Order>(Logger, nameof(CreateOrderAsync), ex);
            }
        }

        public async Task<ISingleResponse<OrderLine>> CreateOrderLineAsync(OrderLine entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateOrderLineAsync));

            try
            {
                UnitOfWork.Repository<OrderLine>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<OrderLine>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<OrderLine>(Logger, nameof(CreateOrderLineAsync), ex);
            }
        }

        public async Task<ISingleResponse<SpecialDeal>> CreateSpecialDealAsync(SpecialDeal entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateSpecialDealAsync));

            try
            {
                UnitOfWork.Repository<SpecialDeal>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<SpecialDeal>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<SpecialDeal>(Logger, nameof(CreateSpecialDealAsync), ex);
            }
        }

        public async Task<IResponse> DeleteBuyingGroupAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteBuyingGroupAsync));

            try
            {
                var entity = UnitOfWork.Repository<BuyingGroup>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteBuyingGroupAsync), $"BuyingGroup with id {id} not found");

                UnitOfWork.Repository<BuyingGroup>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteBuyingGroupAsync), ex);
            }
        }

        public async Task<IResponse> DeleteCustomerAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteCustomerAsync));

            try
            {
                var entity = UnitOfWork.Repository<Customer>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteCustomerAsync), $"Customer with id {id} not found");

                UnitOfWork.Repository<Customer>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteCustomerAsync), ex);
            }
        }

        public async Task<IResponse> DeleteCustomerCategoryAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteCustomerCategoryAsync));

            try
            {
                var entity = UnitOfWork.Repository<CustomerCategory>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteCustomerCategoryAsync), $"CustomerCategory with id {id} not found");

                UnitOfWork.Repository<CustomerCategory>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteCustomerCategoryAsync), ex);
            }
        }

        public async Task<IResponse> DeleteCustomerTransactionAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteCustomerTransactionAsync));

            try
            {
                var entity = UnitOfWork.Repository<CustomerTransaction>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteCustomerTransactionAsync), $"CustomerTransaction with id {id} not found");

                UnitOfWork.Repository<CustomerTransaction>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteCustomerTransactionAsync), ex);
            }
        }

        public async Task<IResponse> DeleteInvoiceAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteInvoiceAsync));

            try
            {
                var entity = UnitOfWork.Repository<Invoice>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteInvoiceAsync), $"Invoice with id {id} not found");

                UnitOfWork.Repository<Invoice>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteInvoiceAsync), ex);
            }
        }

        public async Task<IResponse> DeleteInvoiceLineAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteInvoiceLineAsync));

            try
            {
                var entity = UnitOfWork.Repository<InvoiceLine>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteInvoiceLineAsync), $"InvoiceLine with id {id} not found");

                UnitOfWork.Repository<InvoiceLine>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteInvoiceLineAsync), ex);
            }
        }

        public async Task<IResponse> DeleteOrderAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteOrderAsync));

            try
            {
                var entity = UnitOfWork.Repository<Order>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteOrderAsync), $"Order with id {id} not found");

                UnitOfWork.Repository<Order>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteOrderAsync), ex);
            }
        }

        public async Task<IResponse> DeleteOrderLineAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteOrderLineAsync));

            try
            {
                var entity = UnitOfWork.Repository<OrderLine>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteOrderLineAsync), $"OrderLine with id {id} not found");

                UnitOfWork.Repository<OrderLine>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteOrderLineAsync), ex);
            }
        }

        public async Task<IResponse> DeleteSpecialDealAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteSpecialDealAsync));

            try
            {
                var entity = UnitOfWork.Repository<SpecialDeal>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteSpecialDealAsync), $"SpecialDeal with id {id} not found");

                UnitOfWork.Repository<SpecialDeal>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteSpecialDealAsync), ex);
            }
        }

        public async Task<ISingleResponse<BuyingGroup>> GetBuyingGroupAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetBuyingGroupAsync));

            var response = new SingleResponse<BuyingGroup>();

            try
            {
                return new SingleResponse<BuyingGroup>(await UnitOfWork.Repository<BuyingGroup>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<BuyingGroup>(Logger, nameof(GetBuyingGroupAsync), ex);
            }
        }

        public async Task<IPagedResponse<BuyingGroup>> GetBuyingGroupsAsync(int pageSize = 10, int pageNumber = 1)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetBuyingGroupsAsync));

            var response = new PagedResponse<BuyingGroup>();

            try
            {
                response.Model = await UnitOfWork.Repository<BuyingGroup>().GetAsync(includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<BuyingGroup>(Logger, nameof(GetBuyingGroupsAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<Customer>> GetCustomerAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetCustomerAsync));

            var response = new SingleResponse<Customer>();

            try
            {
                return new SingleResponse<Customer>(await UnitOfWork.Repository<Customer>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<Customer>(Logger, nameof(GetCustomerAsync), ex);
            }
        }

        public async Task<IPagedResponse<CustomerCategory>> GetCustomerCategoriesAsync(int pageSize = 10, int pageNumber = 1)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetCustomerCategoriesAsync));

            var response = new PagedResponse<CustomerCategory>();

            try
            {
                response.Model = await UnitOfWork.Repository<CustomerCategory>().GetAsync(includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<CustomerCategory>(Logger, nameof(GetCustomerCategoriesAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<CustomerCategory>> GetCustomerCategoryAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetCustomerCategoryAsync));

            var response = new SingleResponse<CustomerCategory>();

            try
            {
                return new SingleResponse<CustomerCategory>(await UnitOfWork.Repository<CustomerCategory>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<CustomerCategory>(Logger, nameof(GetCustomerCategoryAsync), ex);
            }
        }

        public async Task<IPagedResponse<Customer>> GetCustomersAsync(int pageSize = 10, int pageNumber = 1, int? customerCategoryId = null, int? buyingGroupId = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetCustomersAsync));

            var response = new PagedResponse<Customer>();

            try
            {
                Expression<Func<Customer, bool>> predicate = c => true;

                if (customerCategoryId.HasValue)
                    predicate = predicate.And(c => c.CustomerCategoryId == customerCategoryId);

                if (buyingGroupId.HasValue)
                    predicate = predicate.And(c => c.BuyingGroupId == buyingGroupId);

                response.Model = await UnitOfWork.Repository<Customer>().GetAsync(predicate, includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<Customer>(Logger, nameof(GetCustomersAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<CustomerTransaction>> GetCustomerTransactionAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetCustomerTransactionAsync));

            var response = new SingleResponse<CustomerTransaction>();

            try
            {
                return new SingleResponse<CustomerTransaction>(await UnitOfWork.Repository<CustomerTransaction>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<CustomerTransaction>(Logger, nameof(GetCustomerTransactionAsync), ex);
            }
        }

        public async Task<IPagedResponse<CustomerTransaction>> GetCustomerTransactionsAsync(int pageSize = 10, int pageNumber = 1, int? customerId = null, int? transactionTypeId = null, int? invoiceId = null, int? paymentMethodId = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetCustomerTransactionsAsync));

            var response = new PagedResponse<CustomerTransaction>();

            try
            {
                Expression<Func<CustomerTransaction, bool>> predicate = c => true;

                if (customerId.HasValue)
                    predicate = predicate.And(c => c.CustomerId == customerId);

                if (transactionTypeId.HasValue)
                    predicate = predicate.And(c => c.TransactionTypeId == transactionTypeId);

                if (invoiceId.HasValue)
                    predicate = predicate.And(c => c.InvoiceId == invoiceId);

                if (paymentMethodId.HasValue)
                    predicate = predicate.And(c => c.PaymentMethodId == paymentMethodId);

                response.Model = await UnitOfWork.Repository<CustomerTransaction>().GetAsync(predicate, includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<CustomerTransaction>(Logger, nameof(GetCustomerTransactionsAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<Invoice>> GetInvoiceAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetInvoiceAsync));

            var response = new SingleResponse<Invoice>();

            try
            {
                return new SingleResponse<Invoice>(await UnitOfWork.Repository<Invoice>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<Invoice>(Logger, nameof(GetInvoiceAsync), ex);
            }
        }

        public async Task<ISingleResponse<InvoiceLine>> GetInvoiceLineAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetInvoiceLineAsync));

            var response = new SingleResponse<InvoiceLine>();

            try
            {
                return new SingleResponse<InvoiceLine>(await UnitOfWork.Repository<InvoiceLine>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<InvoiceLine>(Logger, nameof(GetInvoiceLineAsync), ex);
            }
        }

        public async Task<IPagedResponse<InvoiceLine>> GetInvoiceLinesAsync(int? pageSize = 10, int? pageNumber = 1, int? invoiceId = null, int? stockItemId = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetInvoiceLinesAsync));

            var response = new PagedResponse<InvoiceLine>();

            try
            {
                Expression<Func<InvoiceLine, bool>> predicate = i => true;

                if (invoiceId.HasValue)
                    predicate = predicate.And(i => i.InvoiceId == invoiceId);

                if (stockItemId.HasValue)
                    predicate = predicate.And(i => i.StockItemId == stockItemId);

                response.Model = await UnitOfWork.Repository<InvoiceLine>().GetAsync(predicate, includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<InvoiceLine>(Logger, nameof(GetInvoiceLinesAsync), ex);
            }

            return response;
        }

        public async Task<IPagedResponse<Invoice>> GetInvoicesAsync(int pageSize = 10, int pageNumber = 1, int? customerId = null, int? orderId = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetInvoicesAsync));

            var response = new PagedResponse<Invoice>();

            try
            {
                Expression<Func<Invoice, bool>> predicate = i => true;

                if (customerId.HasValue)
                    predicate = predicate.And(i => i.CustomerId == customerId);

                if (orderId.HasValue)
                    predicate = predicate.And(i => i.OrderId == orderId);

                response.Model = await UnitOfWork.Repository<Invoice>().GetAsync(predicate, includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<Invoice>(Logger, nameof(GetInvoicesAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<Order>> GetOrderAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetOrderAsync));

            var response = new SingleResponse<Order>();

            try
            {
                return new SingleResponse<Order>(await UnitOfWork.Repository<Order>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<Order>(Logger, nameof(GetOrderAsync), ex);
            }
        }

        public async Task<ISingleResponse<OrderLine>> GetOrderLineAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetOrderLineAsync));

            var response = new SingleResponse<OrderLine>();

            try
            {
                return new SingleResponse<OrderLine>(await UnitOfWork.Repository<OrderLine>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<OrderLine>(Logger, nameof(GetOrderLineAsync), ex);
            }
        }

        public async Task<IPagedResponse<OrderLine>> GetOrderLinesAsync(int pageSize = 10, int pageNumber = 1, int? orderId = null, int? stockItemId = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetOrderLinesAsync));

            var response = new PagedResponse<OrderLine>();

            try
            {
                Expression<Func<OrderLine, bool>> predicate = i => true;

                if (orderId.HasValue)
                    predicate = predicate.And(i => i.OrderId == orderId);

                if (stockItemId.HasValue)
                    predicate = predicate.And(i => i.StockItemId == stockItemId);

                response.Model = await UnitOfWork.Repository<OrderLine>().GetAsync(predicate, includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<OrderLine>(Logger, nameof(GetOrderLinesAsync), ex);
            }

            return response;
        }

        public async Task<IPagedResponse<Order>> GetOrdersAsync(int pageSize = 10, int pageNumber = 1, int? customerId = null, int? salespersonInvoiceId = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetOrdersAsync));

            var response = new PagedResponse<Order>();

            try
            {
                Expression<Func<Order, bool>> predicate = i => true;

                if (customerId.HasValue)
                    predicate = predicate.And(i => i.CustomerId == customerId);

                if (salespersonInvoiceId.HasValue)
                    predicate = predicate.And(i => i.SalespersonPersonId == salespersonInvoiceId);

                response.Model = await UnitOfWork.Repository<Order>().GetAsync(predicate, includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<Order>(Logger, nameof(GetOrdersAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<SpecialDeal>> GetSpecialDealAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetSpecialDealAsync));

            var response = new SingleResponse<SpecialDeal>();

            try
            {
                return new SingleResponse<SpecialDeal>(await UnitOfWork.Repository<SpecialDeal>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<SpecialDeal>(Logger, nameof(GetSpecialDealAsync), ex);
            }
        }

        public async Task<IPagedResponse<SpecialDeal>> GetSpecialDealsAsync(int pageSize = 10, int pageNumber = 1, int? stockItemId = null, int? customerId = null, int? buyingGroupId = null, int? customerCategoryId = null, int? stockGroupId = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetSpecialDealsAsync));

            var response = new PagedResponse<SpecialDeal>();

            try
            {
                Expression<Func<SpecialDeal, bool>> predicate = d => true;

                if (stockItemId.HasValue)
                    predicate = predicate.And(d => d.StockItemId == stockItemId);

                if (customerId.HasValue)
                    predicate = predicate.And(d => d.CustomerId == customerId);

                if (buyingGroupId.HasValue)
                    predicate = predicate.And(d => d.BuyingGroupId == buyingGroupId);

                if (customerCategoryId.HasValue)
                    predicate = predicate.And(d => d.CustomerCategoryId == customerCategoryId);

                if (stockGroupId.HasValue)
                    predicate = predicate.And(d => d.StockGroupId == stockGroupId);

                response.Model = await UnitOfWork.Repository<SpecialDeal>().GetAsync(predicate, includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<SpecialDeal>(Logger, nameof(GetSpecialDealsAsync), ex);
            }

            return response;
        }

        public async Task<IResponse> UpdateBuyingGroupAsync(BuyingGroup entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateBuyingGroupAsync));

            try
            {
                UnitOfWork.Repository<BuyingGroup>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateBuyingGroupAsync), ex);
            }
        }

        public async Task<IResponse> UpdateCustomerAsync(Customer entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateCustomerAsync));

            try
            {
                UnitOfWork.Repository<Customer>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateCustomerAsync), ex);
            }
        }

        public async Task<IResponse> UpdateCustomerCategoryAsync(CustomerCategory entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateCustomerCategoryAsync));

            try
            {
                UnitOfWork.Repository<CustomerCategory>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateCustomerCategoryAsync), ex);
            }
        }

        public async Task<IResponse> UpdateCustomerTransactionAsync(CustomerTransaction entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateCustomerTransactionAsync));

            try
            {
                UnitOfWork.Repository<CustomerTransaction>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateCustomerTransactionAsync), ex);
            }
        }

        public async Task<IResponse> UpdateInvoiceAsync(Invoice entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateInvoiceAsync));

            try
            {
                UnitOfWork.Repository<Invoice>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateInvoiceAsync), ex);
            }
        }

        public async Task<IResponse> UpdateInvoiceLineAsync(InvoiceLine entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateInvoiceLineAsync));

            try
            {
                UnitOfWork.Repository<InvoiceLine>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateInvoiceLineAsync), ex);
            }
        }

        public async Task<IResponse> UpdateOrderAsync(Order entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateOrderAsync));

            try
            {
                UnitOfWork.Repository<Order>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateOrderAsync), ex);
            }
        }

        public async Task<IResponse> UpdateOrderLineAsync(OrderLine entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateOrderLineAsync));

            try
            {
                UnitOfWork.Repository<OrderLine>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateOrderLineAsync), ex);
            }
        }

        public async Task<IResponse> UpdateSpecialDealAsync(SpecialDeal entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateSpecialDealAsync));

            try
            {
                UnitOfWork.Repository<SpecialDeal>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateSpecialDealAsync), ex);
            }
        }
    }
}