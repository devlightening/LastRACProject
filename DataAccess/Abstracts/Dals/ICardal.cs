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
    public interface ICardal : IEntityRepository<Car>
    {
        CarDetailsDto GetCarDetailsById(Expression<Func<CarDetailsDto, bool>> filter);
        List<CarDetailsDto> GetAllCarDetails(Expression<Func<CarDetailsDto, bool>> filter = null);
    }
}
