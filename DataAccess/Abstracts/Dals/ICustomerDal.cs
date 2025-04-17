using Core.DataAccess.Repositories;
using Entites.Concretes.DTOs;
using Entites.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts.Dals
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        List<CustomerDetailsDto> GetAllCustomerDetails(Expression<Func<CustomerDetailsDto,bool >> filter = null);
        CustomerDetailsDto GetCustomerDetailById(Expression<Func<CustomerDetailsDto, bool>> filter);
    }
}
