using ApiHookup.Dto;

namespace ApiHookup.Interfaces
{
    public interface IAuthService
    {
        public string Login(loginDto dto);  
    }
}
