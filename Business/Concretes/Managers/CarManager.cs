using Business.Abstracts.Services;
using Core.Utilities.Results.Abstracts;
using Entites.Concretes.DTOs;
using Entites.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes.Managers
{
    public class CarManager : ICarService
    {
        public IResult Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAll(Car entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Car> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarDetailsDto> GetCarDetailId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailsDto>> GetCarsByBrand(string brand)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailsDto>> GetCarsByColor(string color)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailsDto>> GetCarsDetails()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
