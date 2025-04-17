using Business.Abstracts.Repository;
using Entites.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts.Services
{
    public interface IPaymentService : IServiceRepository<Payment>
    {
    }
}
