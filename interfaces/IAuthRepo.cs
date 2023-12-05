using apihookup.be;
using apihookup.dto;

namespace apihookup.interfaces
{
    public interface IAuthRepo
    { 
        public User getUser(loginDto dto);
    }
}
