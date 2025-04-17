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
    public interface IUserCardService : IServiceRepository<UserCard>
    {
        IDataResult<UserCardDetailsDto> GetUserCardById(int id);
        IDataResult<List<UserCardDetailsDto>> GetUserCardByUserId(int userId);
    }
}
