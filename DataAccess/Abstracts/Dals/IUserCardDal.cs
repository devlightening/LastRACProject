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
    public interface IUserCardDal : IEntityRepository<UserCard>
    {
        UserCardDetailsDto GetUserCardById(Expression<Func<UserCardDetailsDto,bool>> filter );
        List<UserCardDetailsDto> GetUserCardsByUserId(Expression<Func<UserCardDetailsDto,bool>> filter);
    }
}
