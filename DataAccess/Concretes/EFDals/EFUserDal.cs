using Core.DataAccess.Repositories;
using Core.Entities.Concretes;
using DataAccess.Abstracts.Dals;
using DataAccess.Concretes.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.EFDals
{
    public class EFUserDal : EntityRepository<User, EfProjectContext>, IUserDal
    {
        public void AddUserClaim(UserOperationClaim entity)
        {
            using (var context = new EfProjectContext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new EfProjectContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.ClaimId
                             where userOperationClaim.UserId == user.UserId
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();
            }
        }
    }
}
