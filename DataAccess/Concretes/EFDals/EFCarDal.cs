using Core.DataAccess.Repositories;
using DataAccess.Abstracts.Dals;
using DataAccess.Concretes.Contexts;
using Entites.Concretes.DTOs;
using Entites.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EFDals
{
    public class EFCarDal : EntityRepository<Car, EfProjectContext>, ICardal
    {
        public List<CarDetailsDto> GetAllCarDetails(Expression<Func<CarDetailsDto, bool>> filter = null)
        {
            using (EfProjectContext context = new EfProjectContext()) {
            #region Data
            IQueryable<CarDetailsDto> data = createData(context);
            #endregion

            return filter == null ? data.ToList() : data.Where(filter).ToList();
            }
        }

        private static IQueryable<CarDetailsDto> createData(EfProjectContext context)
        {
            return from car in context.Cars
                   join bra in context.Brands on car.BrandId equals bra.BrandId
                   join col in context.Colors on car.ColorId equals col.ColorId

                   select new CarDetailsDto
                   {
                       CarId = car.CarId,
                       CarName =car.CarName,
                       BrandName=bra.BrandName,
                       ColorName=col.ColorName,
                       DailyPrice=car.DailyPrice,
                       ModelYear=car.ModelYear,
                       Description=car.Description,
                   };
        }

        public CarDetailsDto GetCarDetailsById(Expression<Func<CarDetailsDto, bool>> filter)
        {
            using (EfProjectContext context = new EfProjectContext())
            {
                #region Data
                IQueryable<CarDetailsDto> data = createData(context);
                #endregion 

                return data.FirstOrDefault(filter);

            }
        }
    }
}
