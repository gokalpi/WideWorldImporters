using Microsoft.Extensions.Logging;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WideWorldImporters.Application.Interfaces;
using WideWorldImporters.Application.Responses;
using WideWorldImporters.Core.Entities.Application;
using WideWorldImporters.Core.Interfaces;

namespace WideWorldImporters.Application.Services
{
    public class ApplicationService : Service, IApplicationService
    {
        public ApplicationService(ILogger<ApplicationService> logger, IUnitOfWork unitOfWork)
            : base(logger, unitOfWork)
        {
        }

        public async Task<ISingleResponse<City>> CreateCityAsync(City entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateCityAsync));

            try
            {
                UnitOfWork.Repository<City>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<City>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<City>(Logger, nameof(CreateCityAsync), ex);
            }
        }

        public async Task<ISingleResponse<Country>> CreateCountryAsync(Country entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateCountryAsync));

            try
            {
                UnitOfWork.Repository<Country>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<Country>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Country>(Logger, nameof(CreateCountryAsync), ex);
            }
        }

        public async Task<ISingleResponse<DeliveryMethod>> CreateDeliveryMethodAsync(DeliveryMethod entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateDeliveryMethodAsync));

            try
            {
                UnitOfWork.Repository<DeliveryMethod>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<DeliveryMethod>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<DeliveryMethod>(Logger, nameof(CreateDeliveryMethodAsync), ex);
            }
        }

        public async Task<ISingleResponse<PaymentMethod>> CreatePaymentMethodAsync(PaymentMethod entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreatePaymentMethodAsync));

            try
            {
                UnitOfWork.Repository<PaymentMethod>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<PaymentMethod>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<PaymentMethod>(Logger, nameof(CreatePaymentMethodAsync), ex);
            }
        }

        public async Task<ISingleResponse<Person>> CreatePersonAsync(Person entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreatePersonAsync));

            try
            {
                UnitOfWork.Repository<Person>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<Person>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<Person>(Logger, nameof(CreatePersonAsync), ex);
            }
        }

        public async Task<ISingleResponse<StateProvince>> CreateStateProvinceAsync(StateProvince entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateStateProvinceAsync));

            try
            {
                UnitOfWork.Repository<StateProvince>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<StateProvince>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<StateProvince>(Logger, nameof(CreateStateProvinceAsync), ex);
            }
        }

        public async Task<ISingleResponse<SystemParameter>> CreateSystemParameterAsync(SystemParameter entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateSystemParameterAsync));

            try
            {
                UnitOfWork.Repository<SystemParameter>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<SystemParameter>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<SystemParameter>(Logger, nameof(CreateSystemParameterAsync), ex);
            }
        }

        public async Task<ISingleResponse<TransactionType>> CreateTransactionTypeAsync(TransactionType entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(CreateTransactionTypeAsync));

            try
            {
                UnitOfWork.Repository<TransactionType>().Add(entity);
                await UnitOfWork.SaveChangesAsync();

                return new SingleResponse<TransactionType>(entity);
            }
            catch (Exception ex)
            {
                return new SingleResponse<TransactionType>(Logger, nameof(CreateTransactionTypeAsync), ex);
            }
        }

        public async Task<IResponse> DeleteCityAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteCityAsync));

            try
            {
                var entity = UnitOfWork.Repository<City>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteCityAsync), $"City with id {id} not found");

                UnitOfWork.Repository<City>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteCityAsync), ex);
            }
        }

        public async Task<IResponse> DeleteCountryAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteCountryAsync));

            try
            {
                var entity = UnitOfWork.Repository<Country>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteCountryAsync), $"Country with id {id} not found");

                UnitOfWork.Repository<Country>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteCountryAsync), ex);
            }
        }

        public async Task<IResponse> DeleteDeliveryMethodAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteDeliveryMethodAsync));

            try
            {
                var entity = UnitOfWork.Repository<DeliveryMethod>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteDeliveryMethodAsync), $"DeliveryMethod with id {id} not found");

                UnitOfWork.Repository<DeliveryMethod>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteDeliveryMethodAsync), ex);
            }
        }

        public async Task<IResponse> DeletePaymentMethodAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeletePaymentMethodAsync));

            try
            {
                var entity = UnitOfWork.Repository<PaymentMethod>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeletePaymentMethodAsync), $"PaymentMethod with id {id} not found");

                UnitOfWork.Repository<PaymentMethod>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeletePaymentMethodAsync), ex);
            }
        }

        public async Task<IResponse> DeletePersonAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeletePersonAsync));

            try
            {
                var entity = UnitOfWork.Repository<Person>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeletePersonAsync), $"Person with id {id} not found");

                UnitOfWork.Repository<Person>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeletePersonAsync), ex);
            }
        }

        public async Task<IResponse> DeleteStateProvinceAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteStateProvinceAsync));

            try
            {
                var entity = UnitOfWork.Repository<StateProvince>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteStateProvinceAsync), $"StateProvince with id {id} not found");

                UnitOfWork.Repository<StateProvince>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteStateProvinceAsync), ex);
            }
        }

        public async Task<IResponse> DeleteSystemParameterAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteSystemParameterAsync));

            try
            {
                var entity = UnitOfWork.Repository<SystemParameter>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteSystemParameterAsync), $"SystemParameter with id {id} not found");

                UnitOfWork.Repository<SystemParameter>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteSystemParameterAsync), ex);
            }
        }

        public async Task<IResponse> DeleteTransactionTypeAsync(int id)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(DeleteTransactionTypeAsync));

            try
            {
                var entity = UnitOfWork.Repository<TransactionType>().GetById(id);
                if (null == entity)
                    return new Response(Logger, nameof(DeleteTransactionTypeAsync), $"TransactionType with id {id} not found");

                UnitOfWork.Repository<TransactionType>().Delete(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(DeleteTransactionTypeAsync), ex);
            }
        }

        public async Task<IPagedResponse<City>> GetCitiesAsync(int pageSize = 10, int pageNumber = 1, int? stateProvinceId = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetCitiesAsync));

            var response = new PagedResponse<City>();

            try
            {
                Expression<Func<City, bool>> predicate = c => (stateProvinceId.HasValue) ? c.StateProvinceId == stateProvinceId : true;

                response.Model = await UnitOfWork.Repository<City>().GetAsync(predicate, includeString: "Country", page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<City>(Logger, nameof(GetCitiesAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<City>> GetCityAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetCityAsync));

            var response = new SingleResponse<City>();

            try
            {
                return new SingleResponse<City>(await UnitOfWork.Repository<City>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<City>(Logger, nameof(GetCityAsync), ex);
            }
        }

        public async Task<IPagedResponse<Country>> GetCountriesAsync(int pageSize = 10, int pageNumber = 1)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetCountriesAsync));

            var response = new PagedResponse<Country>();

            try
            {
                response.Model = await UnitOfWork.Repository<Country>().GetAsync(includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<Country>(Logger, nameof(GetCountriesAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<Country>> GetCountryAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetCountryAsync));

            var response = new SingleResponse<Country>();

            try
            {
                return new SingleResponse<Country>(await UnitOfWork.Repository<Country>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<Country>(Logger, nameof(GetCountryAsync), ex);
            }
        }

        public async Task<ISingleResponse<DeliveryMethod>> GetDeliveryMethodAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetDeliveryMethodAsync));

            var response = new SingleResponse<DeliveryMethod>();

            try
            {
                return new SingleResponse<DeliveryMethod>(await UnitOfWork.Repository<DeliveryMethod>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<DeliveryMethod>(Logger, nameof(GetDeliveryMethodAsync), ex);
            }
        }

        public async Task<IPagedResponse<DeliveryMethod>> GetDeliveryMethodsAsync(int pageSize = 10, int pageNumber = 1)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetDeliveryMethodsAsync));

            var response = new PagedResponse<DeliveryMethod>();

            try
            {
                response.Model = await UnitOfWork.Repository<DeliveryMethod>().GetAsync(includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<DeliveryMethod>(Logger, nameof(GetDeliveryMethodsAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<PaymentMethod>> GetPaymentMethodAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetPaymentMethodAsync));

            var response = new SingleResponse<PaymentMethod>();

            try
            {
                return new SingleResponse<PaymentMethod>(await UnitOfWork.Repository<PaymentMethod>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<PaymentMethod>(Logger, nameof(GetPaymentMethodAsync), ex);
            }
        }

        public async Task<IPagedResponse<PaymentMethod>> GetPaymentMethodsAsync(int pageSize = 10, int pageNumber = 1)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetPaymentMethodsAsync));

            var response = new PagedResponse<PaymentMethod>();

            try
            {
                response.Model = await UnitOfWork.Repository<PaymentMethod>().GetAsync(includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<PaymentMethod>(Logger, nameof(GetPaymentMethodsAsync), ex);
            }

            return response;
        }

        public async Task<IPagedResponse<Person>> GetPeopleAsync(int pageSize = 10, int pageNumber = 1)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetPeopleAsync));

            var response = new PagedResponse<Person>();

            try
            {
                response.Model = await UnitOfWork.Repository<Person>().GetAsync(includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<Person>(Logger, nameof(GetPeopleAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<Person>> GetPersonAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetPersonAsync));

            var response = new SingleResponse<Person>();

            try
            {
                return new SingleResponse<Person>(await UnitOfWork.Repository<Person>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<Person>(Logger, nameof(GetPersonAsync), ex);
            }
        }

        public async Task<ISingleResponse<StateProvince>> GetStateProvinceAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetStateProvinceAsync));

            var response = new SingleResponse<StateProvince>();

            try
            {
                return new SingleResponse<StateProvince>(await UnitOfWork.Repository<StateProvince>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<StateProvince>(Logger, nameof(GetStateProvinceAsync), ex);
            }
        }

        public async Task<IPagedResponse<StateProvince>> GetStateProvincesAsync(int pageSize = 10, int pageNumber = 1, int? countryId = null)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetStateProvincesAsync));

            var response = new PagedResponse<StateProvince>();

            try
            {
                Expression<Func<StateProvince, bool>> predicate = s => (countryId.HasValue) ? s.CountryId == countryId : true;

                response.Model = await UnitOfWork.Repository<StateProvince>().GetAsync(predicate, includeString: "Country", page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<StateProvince>(Logger, nameof(GetStateProvincesAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<SystemParameter>> GetSystemParameterAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetSystemParameterAsync));

            var response = new SingleResponse<SystemParameter>();

            try
            {
                return new SingleResponse<SystemParameter>(await UnitOfWork.Repository<SystemParameter>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<SystemParameter>(Logger, nameof(GetSystemParameterAsync), ex);
            }
        }

        public async Task<IPagedResponse<SystemParameter>> GetSystemParametersAsync(int pageSize = 10, int pageNumber = 1)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetSystemParametersAsync));

            var response = new PagedResponse<SystemParameter>();

            try
            {
                response.Model = await UnitOfWork.Repository<SystemParameter>().GetAsync(includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<SystemParameter>(Logger, nameof(GetSystemParametersAsync), ex);
            }

            return response;
        }

        public async Task<ISingleResponse<TransactionType>> GetTransactionTypeAsync(int id)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetTransactionTypeAsync));

            var response = new SingleResponse<TransactionType>();

            try
            {
                return new SingleResponse<TransactionType>(await UnitOfWork.Repository<TransactionType>().GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return new SingleResponse<TransactionType>(Logger, nameof(GetTransactionTypeAsync), ex);
            }
        }

        public async Task<IPagedResponse<TransactionType>> GetTransactionTypesAsync(int pageSize = 10, int pageNumber = 1)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetTransactionTypesAsync));

            var response = new PagedResponse<TransactionType>();

            try
            {
                response.Model = await UnitOfWork.Repository<TransactionType>().GetAsync(includeString: null, page: pageNumber, pageSize: pageSize);
            }
            catch (Exception ex)
            {
                return new PagedResponse<TransactionType>(Logger, nameof(GetTransactionTypesAsync), ex);
            }

            return response;
        }

        public async Task<IResponse> UpdateCityAsync(City entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateCityAsync));

            try
            {
                UnitOfWork.Repository<City>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateCityAsync), ex);
            }
        }

        public async Task<IResponse> UpdateCountryAsync(Country entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateCountryAsync));

            try
            {
                UnitOfWork.Repository<Country>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateCountryAsync), ex);
            }
        }

        public async Task<IResponse> UpdateDeliveryMethodAsync(DeliveryMethod entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateDeliveryMethodAsync));

            try
            {
                UnitOfWork.Repository<DeliveryMethod>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateDeliveryMethodAsync), ex);
            }
        }

        public async Task<IResponse> UpdatePaymentMethodAsync(PaymentMethod entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdatePaymentMethodAsync));

            try
            {
                UnitOfWork.Repository<PaymentMethod>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdatePaymentMethodAsync), ex);
            }
        }

        public async Task<IResponse> UpdatePersonAsync(Person entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdatePersonAsync));

            try
            {
                UnitOfWork.Repository<Person>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdatePersonAsync), ex);
            }
        }

        public async Task<IResponse> UpdateStateProvinceAsync(StateProvince entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateStateProvinceAsync));

            try
            {
                UnitOfWork.Repository<StateProvince>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateStateProvinceAsync), ex);
            }
        }

        public async Task<IResponse> UpdateSystemParameterAsync(SystemParameter entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateSystemParameterAsync));

            try
            {
                UnitOfWork.Repository<SystemParameter>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateSystemParameterAsync), ex);
            }
        }

        public async Task<IResponse> UpdateTransactionTypeAsync(TransactionType entity)
        {
            Logger?.LogInformation("'{0}' has been invoked", nameof(UpdateTransactionTypeAsync));

            try
            {
                UnitOfWork.Repository<TransactionType>().Update(entity);
                await UnitOfWork.SaveChangesAsync();

                return new Response();
            }
            catch (Exception ex)
            {
                return new Response(Logger, nameof(UpdateTransactionTypeAsync), ex);
            }
        }
    }
}