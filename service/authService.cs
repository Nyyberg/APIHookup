using apihookup.be;
using apihookup.dto;
using apihookup.interfaces;
using apihookup.repository;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace apihookup.service
{
    public class authService : IAuthService
    {
        IAuthRepo _repo = new MockRepo();
        int expiriationTime = 24;

        public string GenerateJSONWebToken(loginDto userInfo)
        {
            var key = Encoding.UTF8.GetBytes("secet");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("username", userInfo.username) }),
                Expires = DateTime.UtcNow.AddHours(expiriationTime),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.Aes128Encryption)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));
        }

        public string login(loginDto dto)
        {
            User  user = _repo.getUser(dto);
            if (user == null)
            {
                throw new Exception("Username or password is not correct");
            }
            else if (user.password != dto.password)
            {
                throw new Exception("Username or password is not correct");
            }
            else
            {
                return GenerateJSONWebToken(dto);
            }
        }
    }
}
