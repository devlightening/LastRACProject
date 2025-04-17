using Core.Entities.Abstracts;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results.Abstracts;

namespace Business.Abstracts.Repository
{
    public interface IServiceRepository<TEntity> where TEntity : class ,IEntity , new()
    {
        IResult Add(TEntity entity);
        IResult Update(TEntity entity);
        IResult Delete(TEntity entity);
        IDataResult<List<TEntity>> GetAll(TEntity entity);
        IDataResult<TEntity> GetById(int id);
    }
}
