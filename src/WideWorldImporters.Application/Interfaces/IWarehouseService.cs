using System.Threading.Tasks;
using WideWorldImporters.Application.Responses;
using WideWorldImporters.Core.Entities.Warehouse;

namespace WideWorldImporters.Application.Interfaces
{
    public interface IWarehouseService : IService
    {
        Task<ISingleResponse<ColdRoomTemperature>> CreateColdRoomTemperatureAsync(ColdRoomTemperature entity);

        Task<ISingleResponse<Color>> CreateColorAsync(Color entity);

        Task<ISingleResponse<PackageType>> CreatePackageTypeAsync(PackageType entity);

        Task<ISingleResponse<StockGroup>> CreateStockGroupAsync(StockGroup entity);

        Task<ISingleResponse<StockItem>> CreateStockItemAsync(StockItem entity);

        Task<ISingleResponse<StockItemHolding>> CreateStockItemHoldingAsync(StockItemHolding entity);

        Task<ISingleResponse<StockItemStockGroup>> CreateStockItemStockGroupAsync(StockItemStockGroup entity);

        Task<ISingleResponse<StockItemTransaction>> CreateStockItemTransactionAsync(StockItemTransaction entity);

        Task<ISingleResponse<VehicleTemperature>> CreateVehicleTemperatureAsync(VehicleTemperature entity);

        Task<IResponse> DeleteColdRoomTemperatureAsync(long id);

        Task<IResponse> DeleteColorAsync(int id);

        Task<IResponse> DeletePackageTypeAsync(int id);

        Task<IResponse> DeleteStockGroupAsync(int id);

        Task<IResponse> DeleteStockItemAsync(int id);

        Task<IResponse> DeleteStockItemHoldingAsync(int id);

        Task<IResponse> DeleteStockItemStockGroupAsync(int id);

        Task<IResponse> DeleteStockItemTransactionAsync(int id);

        Task<IResponse> DeleteVehicleTemperatureAsync(long id);

        Task<ISingleResponse<ColdRoomTemperature>> GetColdRoomTemperatureAsync(long id);

        Task<IPagedResponse<ColdRoomTemperature>> GetColdRoomTemperaturesAsync(int pageSize = 10, int pageNumber = 1, int? coldRoomSensorNumber = null);

        Task<ISingleResponse<Color>> GetColorAsync(int id);

        Task<IPagedResponse<Color>> GetColorsAsync(int pageSize = 10, int pageNumber = 1);

        Task<ISingleResponse<PackageType>> GetPackageTypeAsync(int id);

        Task<IPagedResponse<PackageType>> GetPackageTypesAsync(int pageSize = 10, int pageNumber = 1);

        Task<ISingleResponse<StockGroup>> GetStockGroupAsync(int id);

        Task<IPagedResponse<StockGroup>> GetStockGroupsAsync(int pageSize = 10, int pageNumber = 1);

        Task<ISingleResponse<StockItem>> GetStockItemAsync(int id);

        Task<ISingleResponse<StockItemHolding>> GetStockItemHoldingAsync(int id);

        Task<IPagedResponse<StockItemHolding>> GetStockItemHoldingsAsync(int? pageSize = 10, int? pageNumber = 1, int? stockItemId = null);

        Task<IPagedResponse<StockItem>> GetStockItemsAsync(int pageSize = 10, int pageNumber = 1, int? supplierId = null, int? colorId = null);

        Task<ISingleResponse<StockItemStockGroup>> GetStockItemStockGroupAsync(int id);

        Task<IPagedResponse<StockItemStockGroup>> GetStockItemStockGroupsAsync(int pageSize = 10, int pageNumber = 1, int? stockItemId = null, int? stockGroupId = null);

        Task<ISingleResponse<StockItemTransaction>> GetStockItemTransactionAsync(int id);

        Task<IPagedResponse<StockItemTransaction>> GetStockItemTransactionsAsync(int pageSize = 10, int pageNumber = 1, int? stockItemId = null, int? transactionTypeId = null, int? customerId = null, int? invoiceId = null, int? supplierId = null, int? purchaseOrderId = null);

        Task<ISingleResponse<VehicleTemperature>> GetVehicleTemperatureAsync(long id);

        Task<IPagedResponse<VehicleTemperature>> GetVehicleTemperaturesAsync(int pageSize = 10, int pageNumber = 1, string vehicleRegistration = "", int? chillerSensorNumber = null);

        Task<IResponse> UpdateColdRoomTemperatureAsync(ColdRoomTemperature entity);

        Task<IResponse> UpdateColorAsync(Color entity);

        Task<IResponse> UpdatePackageTypeAsync(PackageType entity);

        Task<IResponse> UpdateStockGroupAsync(StockGroup entity);

        Task<IResponse> UpdateStockItemAsync(StockItem entity);

        Task<IResponse> UpdateStockItemHoldingAsync(StockItemHolding entity);

        Task<IResponse> UpdateStockItemStockGroupAsync(StockItemStockGroup entity);

        Task<IResponse> UpdateStockItemTransactionAsync(StockItemTransaction entity);

        Task<IResponse> UpdateVehicleTemperatureAsync(VehicleTemperature entity);
    }
}