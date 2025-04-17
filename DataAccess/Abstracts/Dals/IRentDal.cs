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
    public interface IRentDal : IEntityRepository<Rental>
    {
        List<RentalDetailsDto> GetAllRentDetails(Expression<Func<RentalDetailsDto,bool>> filter = null);
        RentalDetailsDto GetRentDetailsById(Expression<Func<RentalDetailsDto, bool>> filter);
        Rental GetByCarId(Expression<Func<Rental, bool>> filter);
    }
}
