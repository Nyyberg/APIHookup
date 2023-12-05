using apihookup.dto;
using apihookup.interfaces;
using apihookup.repository;

namespace apihookup.service
{
    public class authService : IAuthService
    {
        IAuthRepo _repo = new MockRepo();
        public string login(loginDto dto)
        {
            return _repo.getToken(dto);
        }
    }
}
