using Core.Utilities.Results.Abstracts;
using Entites.Concretes.Models;


namespace Business.Abstracts.Services
{
    public interface ICarImageService // : IServiceRepository<CarImage>
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int id);
        IDataResult<List<CarImage>> GetByCarId(int id);
        IResult Add(Microsoft.AspNetCore.Http.IFormFile image, CarImage entity);
        IResult Update(Microsoft.AspNetCore.Http.IFormFile image, CarImage entity);
        IResult Delete(CarImage entity);
    }
}
