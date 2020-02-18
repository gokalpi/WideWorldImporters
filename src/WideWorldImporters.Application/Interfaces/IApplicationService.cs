using System.Threading.Tasks;
using WideWorldImporters.Application.Responses;
using WideWorldImporters.Core.Entities.Application;

namespace WideWorldImporters.Application.Interfaces
{
    public interface IApplicationService : IService
    {
        Task<ISingleResponse<City>> CreateCityAsync(City entity);

        Task<ISingleResponse<Country>> CreateCountryAsync(Country entity);

        Task<ISingleResponse<DeliveryMethod>> CreateDeliveryMethodAsync(DeliveryMethod entity);

        Task<ISingleResponse<PaymentMethod>> CreatePaymentMethodAsync(PaymentMethod entity);

        Task<ISingleResponse<Person>> CreatePersonAsync(Person entity);

        Task<ISingleResponse<StateProvince>> CreateStateProvinceAsync(StateProvince entity);

        Task<ISingleResponse<SystemParameter>> CreateSystemParameterAsync(SystemParameter entity);

        Task<ISingleResponse<TransactionType>> CreateTransactionTypeAsync(TransactionType entity);

        Task<IResponse> DeleteCityAsync(int id);

        Task<IResponse> DeleteCountryAsync(int id);

        Task<IResponse> DeleteDeliveryMethodAsync(int id);

        Task<IResponse> DeletePaymentMethodAsync(int id);

        Task<IResponse> DeletePersonAsync(int id);

        Task<IResponse> DeleteStateProvinceAsync(int id);

        Task<IResponse> DeleteSystemParameterAsync(int id);

        Task<IResponse> DeleteTransactionTypeAsync(int id);

        Task<IPagedResponse<City>> GetCitiesAsync(int pageSize = 10, int pageNumber = 1, int? stateProvinceId = null);

        Task<ISingleResponse<City>> GetCityAsync(int id);

        Task<IPagedResponse<Country>> GetCountriesAsync(int pageSize = 10, int pageNumber = 1);

        Task<ISingleResponse<Country>> GetCountryAsync(int id);

        Task<ISingleResponse<DeliveryMethod>> GetDeliveryMethodAsync(int id);

        Task<IPagedResponse<DeliveryMethod>> GetDeliveryMethodsAsync(int pageSize = 10, int pageNumber = 1);

        Task<ISingleResponse<PaymentMethod>> GetPaymentMethodAsync(int id);

        Task<IPagedResponse<PaymentMethod>> GetPaymentMethodsAsync(int pageSize = 10, int pageNumber = 1);

        Task<IPagedResponse<Person>> GetPeopleAsync(int pageSize = 10, int pageNumber = 1);

        Task<ISingleResponse<Person>> GetPersonAsync(int id);

        Task<ISingleResponse<StateProvince>> GetStateProvinceAsync(int id);

        Task<IPagedResponse<StateProvince>> GetStateProvincesAsync(int pageSize = 10, int pageNumber = 1, int? countryId = null);

        Task<ISingleResponse<SystemParameter>> GetSystemParameterAsync(int id);

        Task<IPagedResponse<SystemParameter>> GetSystemParametersAsync(int pageSize = 10, int pageNumber = 1);

        Task<ISingleResponse<TransactionType>> GetTransactionTypeAsync(int id);

        Task<IPagedResponse<TransactionType>> GetTransactionTypesAsync(int pageSize = 10, int pageNumber = 1);

        Task<IResponse> UpdateCityAsync(City entity);

        Task<IResponse> UpdateCountryAsync(Country entity);

        Task<IResponse> UpdateDeliveryMethodAsync(DeliveryMethod entity);

        Task<IResponse> UpdatePaymentMethodAsync(PaymentMethod entity);

        Task<IResponse> UpdatePersonAsync(Person entity);

        Task<IResponse> UpdateStateProvinceAsync(StateProvince entity);

        Task<IResponse> UpdateSystemParameterAsync(SystemParameter entity);

        Task<IResponse> UpdateTransactionTypeAsync(TransactionType entity);
    }
}