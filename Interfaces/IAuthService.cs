using apihookup.dto;

namespace apihookup.interfaces
{
    public interface IAuthService
    {
        string login(IoginDto dto);

        string GenerateJSONWebToken(IoginDto userInfo);
    }
}
