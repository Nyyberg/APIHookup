using apihookup.be;
using apihookup.dto;
using apihookup.helpers;
using apihookup.interfaces;
using apihookup.repository;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace apihookup.service
{
    public class authService : IAuthService
    {
        private readonly IAuthRepo _repo;
        int expiriationTime = 24;
        private readonly AppSettings _appSettings;

        public authService(IOptions<AppSettings> appSettings, IAuthRepo authRepo)
        {
            _repo = authRepo;
            _appSettings = appSettings.Value;
        }



        public string GenerateJSONWebToken(loginDto userInfo)
        {
            var key = Encoding.UTF8.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("username", userInfo.username) }),
                Expires = DateTime.UtcNow.AddHours(expiriationTime),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));
        }

        public string login(loginDto dto)
        {
            var  user = _repo.getUser(dto);
            if (user != null && user.password == dto.password)
            {
                return GenerateJSONWebToken(dto);
            }
            throw new Exception("Invalid password or username");
        }
    }
}
