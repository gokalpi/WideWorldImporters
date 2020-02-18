using Microsoft.Extensions.Logging;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WideWorldImporters.Application.Interfaces;
using WideWorldImporters.Application.Responses;
using WideWorldImporters.Core.Entities.Warehouse;
using WideWorldImporters.Core.Interfaces;

namespace WideWorldImporters.Application.Services
{
    public class WarehouseService : Service, IWarehouseService
    {
        public WarehouseService(ILogger<WarehouseService> logger, IUnitOfWork unitOfWork)
            : base(logger, unitOfWork)
        {
        }

        public async Task<ISingleResponse<ColdRoomTemperature>> CreateColdRoomTemperatureAsync(ColdRoomTemperature entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateColdRoomTemperatureAsync));

            try
            {
                UnitOfWork.Repository<ColdRoomTemperature>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<ColdRoomTemperature>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<ColdRoomTemperature>(Logger, nameof(CreateColdRoomTemperatureAsync), ex);
            }
        }

        public async Task<ISingleResponse<Color>> CreateColorAsync(Color entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateColorAsync));

            try
            {
                UnitOfWork.Repository<Color>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<Color>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Color>(Logger, nameof(CreateColorAsync), ex);
            }
        }

        public async Task<ISingleResponse<PackageType>> CreatePackageTypeAsync(PackageType entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreatePackageTypeAsync));

            try
            {
                UnitOfWork.Repository<PackageType>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<PackageType>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<PackageType>(Logger, nameof(CreatePackageTypeAsync), ex);
            }
        }

        public async Task<ISingleResponse<StockGroup>> CreateStockGroupAsync(StockGroup entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateStockGroupAsync));

            try
            {
                UnitOfWork.Repository<StockGroup>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<StockGroup>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<StockGroup>(Logger, nameof(CreateStockGroupAsync), ex);
            }
        }

        public async Task<ISingleResponse<StockItem>> CreateStockItemAsync(StockItem entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateStockItemAsync));

            try
            {
                UnitOfWork.Repository<StockItem>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<StockItem>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<StockItem>(Logger, nameof(CreateStockItemAsync), ex);
            }
        }

        public async Task<ISingleResponse<StockItemHolding>> CreateStockItemHoldingAsync(StockItemHolding entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateStockItemHoldingAsync));

            try
            {
                UnitOfWork.Repository<StockItemHolding>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<StockItemHolding>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<StockItemHolding>(Logger, nameof(CreateStockItemHoldingAsync), ex);
            }
        }

        public async Task<ISingleResponse<StockItemStockGroup>> CreateStockItemStockGroupAsync(StockItemStockGroup entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateStockItemStockGroupAsync));

            try
            {
                UnitOfWork.Repository<StockItemStockGroup>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<StockItemStockGroup>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<StockItemStockGroup>(Logger, nameof(CreateStockItemStockGroupAsync), ex);
            }
        }

        public async Task<ISingleResponse<StockItemTransaction>> CreateStockItemTransactionAsync(StockItemTransaction entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateStockItemTransactionAsync));

            try
            {
                UnitOfWork.Repository<StockItemTransaction>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<StockItemTransaction>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<StockItemTransaction>(Logger, nameof(CreateStockItemTransactionAsync), ex);
            }
        }

        public async Task<ISingleResponse<VehicleTemperature>> CreateVehicleTemperatureAsync(VehicleTemperature entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateVehicleTemperatureAsync));

            try
            {
                UnitOfWork.Repository<VehicleTemperature>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<VehicleTemperature>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<VehicleTemperature>(Logger, nameof(CreateVehicleTemperatureAsync), ex);
            }
        }

        public async Task<IResponse> DeleteColdRoomTemperatureAsync(long id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteColdRoomTemperatureAsync));

            try
            {
                var entity = UnitOfWork.Repository<ColdRoomTemperature>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteColdRoomTemperatureAsync), $"ColdRoomTemperature with id {id} not found");

                UnitOfWork.Repository<ColdRoomTemperature>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteColdRoomTemperatureAsync), ex);
            }
        }

        public async Task<IResponse> DeleteColorAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteColorAsync));

            try
            {
                var entity = UnitOfWork.Repository<Color>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteColorAsync), $"Color with id {id} not found");

                UnitOfWork.Repository<Color>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteColorAsync), ex);
            }
        }

        public async Task<IResponse> DeletePackageTypeAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeletePackageTypeAsync));

            try
            {
                var entity = UnitOfWork.Repository<PackageType>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeletePackageTypeAsync), $"PackageType with id {id} not found");

                UnitOfWork.Repository<PackageType>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeletePackageTypeAsync), ex);
            }
        }

        public async Task<IResponse> DeleteStockGroupAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteStockGroupAsync));

            try
            {
                var entity = UnitOfWork.Repository<StockGroup>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteStockGroupAsync), $"StockGroup with id {id} not found");

                UnitOfWork.Repository<StockGroup>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteStockGroupAsync), ex);
            }
        }

        public async Task<IResponse> DeleteStockItemAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteStockItemAsync));

            try
            {
                var entity = UnitOfWork.Repository<StockItem>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteStockItemAsync), $"StockItem with id {id} not found");

                UnitOfWork.Repository<StockItem>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteStockItemAsync), ex);
            }
        }

        public async Task<IResponse> DeleteStockItemHoldingAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteStockItemHoldingAsync));

            try
            {
                var entity = UnitOfWork.Repository<StockItemHolding>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteStockItemHoldingAsync), $"StockItemHolding with id {id} not found");

                UnitOfWork.Repository<StockItemHolding>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteStockItemHoldingAsync), ex);
            }
        }

        public async Task<IResponse> DeleteStockItemStockGroupAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteStockItemStockGroupAsync));

            try
            {
                var entity = UnitOfWork.Repository<StockItemStockGroup>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteStockItemStockGroupAsync), $"StockItemStockGroup with id {id} not found");

                UnitOfWork.Repository<StockItemStockGroup>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteStockItemStockGroupAsync), ex);
            }
        }

        public async Task<IResponse> DeleteStockItemTransactionAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteStockItemTransactionAsync));

            try
            {
                var entity = UnitOfWork.Repository<StockItemTransaction>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteStockItemTransactionAsync), $"StockItemTransaction with id {id} not found");

                UnitOfWork.Repository<StockItemTransaction>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteStockItemTransactionAsync), ex);
            }
        }

        public async Task<IResponse> DeleteVehicleTemperatureAsync(long id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteVehicleTemperatureAsync));

            try
            {
                var entity = UnitOfWork.Repository<VehicleTemperature>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteVehicleTemperatureAsync), $"VehicleTemperature with id {id} not found");

                UnitOfWork.Repository<VehicleTemperature>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteVehicleTemperatureAsync), ex);
            }
        }

        public async Task<ISingleResponse<ColdRoomTemperature>> GetColdRoomTemperatureAsync(long id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetColdRoomTemperatureAsync));

            var response = new SingleResponse<ColdRoomTemperature>();

            try
            {
                return new SingleResponse<ColdRoomTemperature>(await UnitOfWork.Repository<ColdRoomTemperature>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<ColdRoomTemperature>(Logger, nameof(GetColdRoomTemperatureAsync), ex);
            }
        }

        public async Task<IPagedResponse<ColdRoomTemperature>> GetColdRoomTemperaturesAsync(int pageSize = 10, int pageNumber = 1, int? coldRoomSensorNumber = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetColdRoomTemperaturesAsync));

            var response = new PagedResponse<ColdRoomTemperature>();

            try
            {
                response.Model = await UnitOfWork.Repository<ColdRoomTemperature>().GetAsync(includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<ColdRoomTemperature>(Logger, nameof(GetColdRoomTemperaturesAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<Color>> GetColorAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetColorAsync));

            var response = new SingleResponse<Color>();

            try
            {
                return new SingleResponse<Color>(await UnitOfWork.Repository<Color>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<Color>(Logger, nameof(GetColorAsync), ex);
            }
        }

        public async Task<IPagedResponse<Color>> GetColorsAsync(int pageSize = 10, int pageNumber = 1)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetColorsAsync));

            var response = new PagedResponse<Color>();

            try
            {
                response.Model = await UnitOfWork.Repository<Color>().GetAsync(includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<Color>(Logger, nameof(GetColorsAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<PackageType>> GetPackageTypeAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetPackageTypeAsync));

            var response = new SingleResponse<PackageType>();

            try
            {
                return new SingleResponse<PackageType>(await UnitOfWork.Repository<PackageType>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<PackageType>(Logger, nameof(GetPackageTypeAsync), ex);
            }
        }

        public async Task<IPagedResponse<PackageType>> GetPackageTypesAsync(int pageSize = 10, int pageNumber = 1)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetPackageTypesAsync));

            var response = new PagedResponse<PackageType>();

            try
            {
                response.Model = await UnitOfWork.Repository<PackageType>().GetAsync(includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<PackageType>(Logger, nameof(GetPackageTypesAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<StockGroup>> GetStockGroupAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetStockGroupAsync));

            var response = new SingleResponse<StockGroup>();

            try
            {
                return new SingleResponse<StockGroup>(await UnitOfWork.Repository<StockGroup>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<StockGroup>(Logger, nameof(GetStockGroupAsync), ex);
            }
        }

        public async Task<IPagedResponse<StockGroup>> GetStockGroupsAsync(int pageSize = 10, int pageNumber = 1)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetStockGroupsAsync));

            var response = new PagedResponse<StockGroup>();

            try
            {
                response.Model = await UnitOfWork.Repository<StockGroup>().GetAsync(includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<StockGroup>(Logger, nameof(GetStockGroupsAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<StockItem>> GetStockItemAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetStockItemAsync));

            var response = new SingleResponse<StockItem>();

            try
            {
                return new SingleResponse<StockItem>(await UnitOfWork.Repository<StockItem>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<StockItem>(Logger, nameof(GetStockItemAsync), ex);
            }
        }

        public async Task<ISingleResponse<StockItemHolding>> GetStockItemHoldingAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetStockItemHoldingAsync));

            var response = new SingleResponse<StockItemHolding>();

            try
            {
                return new SingleResponse<StockItemHolding>(await UnitOfWork.Repository<StockItemHolding>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<StockItemHolding>(Logger, nameof(GetStockItemHoldingAsync), ex);
            }
        }

        public async Task<IPagedResponse<StockItemHolding>> GetStockItemHoldingsAsync(int? pageSize = 10, int? pageNumber = 1, int? stockItemId = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetStockItemHoldingsAsync));

            var response = new PagedResponse<StockItemHolding>();

            try
            {
                Expression<Func<StockItemHolding, bool>> predicate = i => true;

                if (stockItemId.HasValue)
                    predicate = predicate.And(i => i.StockItemId == stockItemId);

                response.Model = await UnitOfWork.Repository<StockItemHolding>().GetAsync(predicate, includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<StockItemHolding>(Logger, nameof(GetStockItemHoldingsAsync), ex);
            }

            return response;
        }

        public async Task<IPagedResponse<StockItem>> GetStockItemsAsync(int pageSize = 10, int pageNumber = 1, int? supplierId = null, int? colorId = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetStockItemsAsync));

            var response = new PagedResponse<StockItem>();

            try
            {
                Expression<Func<StockItem, bool>> predicate = s => true;

                if (supplierId.HasValue)
                    predicate = predicate.And(s => s.SupplierId == supplierId);

                if (colorId.HasValue)
                    predicate = predicate.And(s => s.ColorId == colorId);

                response.Model = await UnitOfWork.Repository<StockItem>().GetAsync(predicate, includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<StockItem>(Logger, nameof(GetStockItemsAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<StockItemStockGroup>> GetStockItemStockGroupAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetStockItemStockGroupAsync));

            var response = new SingleResponse<StockItemStockGroup>();

            try
            {
                return new SingleResponse<StockItemStockGroup>(await UnitOfWork.Repository<StockItemStockGroup>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<StockItemStockGroup>(Logger, nameof(GetStockItemStockGroupAsync), ex);
            }
        }

        public async Task<IPagedResponse<StockItemStockGroup>> GetStockItemStockGroupsAsync(int pageSize = 10, int pageNumber = 1, int? stockItemId = null, int? stockGroupId = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetStockItemStockGroupsAsync));

            var response = new PagedResponse<StockItemStockGroup>();

            try
            {
                Expression<Func<StockItemStockGroup, bool>> predicate = i => true;

                if (stockItemId.HasValue)
                    predicate = predicate.And(i => i.StockItemId == stockItemId);

                if (stockGroupId.HasValue)
                    predicate = predicate.And(i => i.StockGroupId == stockGroupId);

                response.Model = await UnitOfWork.Repository<StockItemStockGroup>().GetAsync(predicate, includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<StockItemStockGroup>(Logger, nameof(GetStockItemStockGroupsAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<StockItemTransaction>> GetStockItemTransactionAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetStockItemTransactionAsync));

            var response = new SingleResponse<StockItemTransaction>();

            try
            {
                return new SingleResponse<StockItemTransaction>(await UnitOfWork.Repository<StockItemTransaction>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<StockItemTransaction>(Logger, nameof(GetStockItemTransactionAsync), ex);
            }
        }

        public async Task<IPagedResponse<StockItemTransaction>> GetStockItemTransactionsAsync(int pageSize = 10, int pageNumber = 1, int? stockItemId = null, int? transactionTypeId = null, int? customerId = null, int? invoiceId = null, int? supplierId = null, int? purchaseOrderId = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetStockItemTransactionsAsync));

            var response = new PagedResponse<StockItemTransaction>();

            try
            {
                Expression<Func<StockItemTransaction, bool>> predicate = i => true;

                if (stockItemId.HasValue)
                    predicate = predicate.And(i => i.StockItemId == stockItemId);

                if (transactionTypeId.HasValue)
                    predicate = predicate.And(i => i.TransactionTypeId == transactionTypeId);

                if (customerId.HasValue)
                    predicate = predicate.And(i => i.CustomerId == customerId);

                if (invoiceId.HasValue)
                    predicate = predicate.And(i => i.InvoiceId == invoiceId);

                if (supplierId.HasValue)
                    predicate = predicate.And(i => i.SupplierId == supplierId);

                if (purchaseOrderId.HasValue)
                    predicate = predicate.And(i => i.PurchaseOrderId == purchaseOrderId);

                response.Model = await UnitOfWork.Repository<StockItemTransaction>().GetAsync(predicate, includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<StockItemTransaction>(Logger, nameof(GetStockItemTransactionsAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<VehicleTemperature>> GetVehicleTemperatureAsync(long id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetVehicleTemperatureAsync));

            var response = new SingleResponse<VehicleTemperature>();

            try
            {
                return new SingleResponse<VehicleTemperature>(await UnitOfWork.Repository<VehicleTemperature>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<VehicleTemperature>(Logger, nameof(GetVehicleTemperatureAsync), ex);
            }
        }

        public async Task<IPagedResponse<VehicleTemperature>> GetVehicleTemperaturesAsync(int pageSize = 10, int pageNumber = 1, string vehicleRegistration = "", int? chillerSensorNumber = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetVehicleTemperaturesAsync));

            var response = new PagedResponse<VehicleTemperature>();

            try
            {
                Expression<Func<VehicleTemperature, bool>> predicate = v => true;

                if (!string.IsNullOrEmpty(vehicleRegistration))
                    predicate = predicate.And(v => v.VehicleRegistration == vehicleRegistration);

                if (chillerSensorNumber.HasValue)
                    predicate = predicate.And(v => v.ChillerSensorNumber == chillerSensorNumber);

                response.Model = await UnitOfWork.Repository<VehicleTemperature>().GetAsync(predicate, includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<VehicleTemperature>(Logger, nameof(GetVehicleTemperaturesAsync), ex);
            }

            return response;
        }

        public async Task<IResponse> UpdateColdRoomTemperatureAsync(ColdRoomTemperature entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateColdRoomTemperatureAsync));

            try
            {
                UnitOfWork.Repository<ColdRoomTemperature>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateColdRoomTemperatureAsync), ex);
            }
        }

        public async Task<IResponse> UpdateColorAsync(Color entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateColorAsync));

            try
            {
                UnitOfWork.Repository<Color>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateColorAsync), ex);
            }
        }

        public async Task<IResponse> UpdatePackageTypeAsync(PackageType entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdatePackageTypeAsync));

            try
            {
                UnitOfWork.Repository<PackageType>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdatePackageTypeAsync), ex);
            }
        }

        public async Task<IResponse> UpdateStockGroupAsync(StockGroup entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateStockGroupAsync));

            try
            {
                UnitOfWork.Repository<StockGroup>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateStockGroupAsync), ex);
            }
        }

        public async Task<IResponse> UpdateStockItemAsync(StockItem entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateStockItemAsync));

            try
            {
                UnitOfWork.Repository<StockItem>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateStockItemAsync), ex);
            }
        }

        public async Task<IResponse> UpdateStockItemHoldingAsync(StockItemHolding entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateStockItemHoldingAsync));

            try
            {
                UnitOfWork.Repository<StockItemHolding>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateStockItemHoldingAsync), ex);
            }
        }

        public async Task<IResponse> UpdateStockItemStockGroupAsync(StockItemStockGroup entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateStockItemStockGroupAsync));

            try
            {
                UnitOfWork.Repository<StockItemStockGroup>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateStockItemStockGroupAsync), ex);
            }
        }

        public async Task<IResponse> UpdateStockItemTransactionAsync(StockItemTransaction entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateStockItemTransactionAsync));

            try
            {
                UnitOfWork.Repository<StockItemTransaction>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateStockItemTransactionAsync), ex);
            }
        }

        public async Task<IResponse> UpdateVehicleTemperatureAsync(VehicleTemperature entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateVehicleTemperatureAsync));

            try
            {
                UnitOfWork.Repository<VehicleTemperature>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateVehicleTemperatureAsync), ex);
            }
        }
    }
}