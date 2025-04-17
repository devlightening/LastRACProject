using Core.DataAccess.Repositories;
using DataAccess.Abstracts.Dals;
using DataAccess.Concretes.Contexts;
using Entites.Concretes.DTOs;
using Entites.Concretes.Models;
using System.Linq.Expressions;

namespace DataAccess.Concretes.EFDals
{
    public class EFUserCardDal : EntityRepository<UserCard, EfProjectContext>, IUserCardDal
    {
        private static IQueryable<UserCardDetailsDto> CreateData(EfProjectContext context)
        {
            return from uc in context.userCards
                   join cc in context.FakeCreditCards on uc.CardId equals cc.Id
                   join us in context.Users on uc.UserId equals us.UserId
                   select new UserCardDetailsDto
                   {
                       Id = uc.Id,
                       UserId=us.UserId,
                       CardId=cc.Id,
                       UserName=(us.FirstName + " " + us.LastName).ToLower(),
                       NameOnTheCard=cc.NameOnTheCard.ToLower(),
                       CardNumber=cc.CardNumber,
                       CardCvv=cc.CardCvv,
                       ExpirationMonth=cc.ExpirationMonth,
                       ExpirationYear=cc.ExpirationYear
                   };

        }
        public UserCardDetailsDto GetUserCardById(Expression<Func<UserCardDetailsDto, bool>> filter)
        {
            using (EfProjectContext context = new EfProjectContext())
            {
                #region Data 
                IQueryable<UserCardDetailsDto> data = CreateData(context);
                #endregion

                return data.FirstOrDefault(filter);
            }
        }

        public List<UserCardDetailsDto> GetUserCardsByUserId(Expression<Func<UserCardDetailsDto, bool>> filter)
        {
            using ( EfProjectContext context = new EfProjectContext())
            {
                IQueryable<UserCardDetailsDto> data = CreateData(context);
                return data.Where(filter).ToList();
            }
        }
    }
}
