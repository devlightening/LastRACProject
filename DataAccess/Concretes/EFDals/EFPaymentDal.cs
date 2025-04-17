using Core.DataAccess.Repositories;
using DataAccess.Abstracts.Dals;
using DataAccess.Concretes.Contexts;
using Entites.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EFDals
{
    public class EFPaymentDal : EntityRepository<Payment , EfProjectContext> , IPaymentDal
    {

    }
}
