using Business.Abstracts.Repository;
using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;
using Entites.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts.Services
{
    public interface IUserService : IServiceRepository<User>
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetByEmail(string email);
        IResult AddUserClaim(UserOperationClaim userOperationClaim);
        IResult UpdateUser(UserForUpdateDto entity);
    }
}
