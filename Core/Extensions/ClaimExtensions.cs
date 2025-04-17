using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace Core.Extensions
{
    public static class ClaimExtensions
    {
        // 1. Kullanıcının e-posta adresini Claim koleksiyonuna ekler
        public static void AddEmail(this ICollection<Claim> claims, string email)
        {
            claims.Add(new Claim(JwtRegisteredClaimNames.Email, email));
        }

        // 2. Kullanıcının adını Claim koleksiyonuna ekler
        public static void AddName(this ICollection<Claim> claims, string name)
        {
            claims.Add(new Claim(JwtRegisteredClaimNames.GivenName, name));
        }

        // 3. Kullanıcının Name Identifier'ını Claim koleksiyonuna ekler (Bu metod yorumlanmış, alternatifi kullanılabilir)
        //public static void AddNameIdentifier(this ICollection<Claim> claims, string nameIdentifier)
        //{
        //    claims.Add(new Claim(ClaimTypes.NameIdentifier, nameIdentifier));
        //}

        // 4. Kullanıcının Name Identifier'ını Claim koleksiyonuna ekler (Alternatif metod)
        public static void AddNameIdentifier(this ICollection<Claim> claims, string nameIdentifier)
        {
            claims.Add(new Claim(JwtRegisteredClaimNames.NameId, nameIdentifier));
        }

        // 5. Kullanıcının rollerini Claim koleksiyonuna ekler (Birden fazla rol olabilir)
        public static void AddRoles(this ICollection<Claim> claims, string[] roles)
        {
            roles.ToList().ForEach(role => claims.Add(new Claim(ClaimTypes.Role, role)));
        }
    }
}
