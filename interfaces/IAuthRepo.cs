using apihookup.dto;

namespace apihookup.interfaces
{
    public interface IAuthRepo
    { 
        string getToken(loginDto dto);
    }
}
