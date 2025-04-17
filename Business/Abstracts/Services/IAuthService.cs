using Azure.Core;
using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;
using Entites.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts.Services
{
    public interface IAuthService 
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IDataResult<AccessToken> CreateAccessToken(User user);
        IResult UserExist(string email);
        IResult AddUserDefaultClaim(UserForRegisterDto userForRegisterDto);


    }
}
