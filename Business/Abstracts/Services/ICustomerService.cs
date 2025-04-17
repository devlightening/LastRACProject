using Business.Abstracts.Repository;
using Core.Utilities.Results.Abstracts;
using Entites.Concretes.DTOs;
using Entites.Concretes.Models;

namespace Business.Abstracts.Services
{
    public interface ICustomerService : IServiceRepository<Customer>
    {
        IDataResult<CustomerDetailsDto> GetCustomerDetailById(int id);
        IDataResult<List<CustomerDetailsDto>> GetCustomerDetails();
    }
}
