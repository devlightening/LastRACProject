using Business.Abstracts.Repository;
using Core.Utilities.Results.Abstracts;
using Entites.Concretes.DTOs;
using Entites.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts.Services
{
    public interface ICarService : IServiceRepository<Car>
    {
        IDataResult<CarDetailsDto> GetCarDetailId(int id);
        IDataResult<List<CarDetailsDto>> GetCarsDetails();
        IDataResult<List<CarDetailsDto>> GetCarsByBrand(string brand);
        IDataResult<List<CarDetailsDto>> GetCarsByColor(string color);

    }
}
