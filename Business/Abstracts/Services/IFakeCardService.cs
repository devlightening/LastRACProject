using Business.Abstracts.Repository;
using Core.Utilities.Results.Abstracts;
using Entites.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts.Services
{
    public interface IFakeCardService : IServiceRepository<FakeCreditCard>
    {
        IDataResult<FakeCreditCard> CheckCard(FakeCreditCard card, decimal price);
    }
}
