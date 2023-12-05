using apihookup.dto;
using apihookup.interfaces;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace apihookup.repository
{
    public class MockRepo : IAuthRepo
    {
        public string getToken(loginDto dto)
        {
            if (dto.username == "admin" && dto.password == "admin")
            {
                return encrypt(dto);
            }
            else
            {
                return null;
            }
        }

        private string encrypt(loginDto dto)
        {
            var bytes = Encoding.UTF8.GetBytes(dto.password + dto.username);
            var sha = new SHA256Managed();
            var hash = sha.ComputeHash(bytes);
            return Encoding.UTF8.GetString(hash);
        }
    }
}
