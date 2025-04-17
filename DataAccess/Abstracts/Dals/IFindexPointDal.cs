using Core.DataAccess.Repositories;
using Entites.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts.Dals
{
    public interface IFindexPointDal : IEntityRepository<UserFindexPoint>
    {
    }
}
