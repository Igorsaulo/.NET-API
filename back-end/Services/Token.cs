using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using DotNetEnv;
using System.Text.Json;
using Ecomerce.Models;


namespace Ecomerce.Services
{
    public class TokenService
    {
        public static string GenerateToken(UserModel user)
        {
            Env.Load();
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Environment.GetEnvironmentVariable("SECRET"));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                      new Claim(ClaimTypes.Email,user.Email.ToString()),
                      new Claim(ClaimTypes.Name, user.Username.ToString()),
                      new Claim(ClaimTypes.GroupSid,user.Category.ToString()),

                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature
                )
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
