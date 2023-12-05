using apihookup.dto;

namespace apihookup.interfaces
{
    public interface IAuthService
    {
        string login(loginDto dto);

        string GenerateJSONWebToken(loginDto userInfo);
    }
}
