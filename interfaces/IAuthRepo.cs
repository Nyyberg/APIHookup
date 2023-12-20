using apihookup.be;
using apihookup.dto;

namespace apihookup.interfaces
{
    public interface IAuthRepo
    { 
        User getUser(IoginDto dto);
    }
}
