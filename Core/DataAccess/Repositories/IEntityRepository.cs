using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Abstracts;


namespace Core.DataAccess.Repositories
{
    public interface IEntityRepository<TEntity> where TEntity : class,IEntity,new()
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void update(TEntity entity);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        int count();

    }
}
