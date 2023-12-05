using apihookup.dto;
using apihookup.interfaces;
using apihookup.service;
using Microsoft.AspNetCore.Mvc;

namespace apihookup.Controllers
{
    public class loginController : ControllerBase
    {
        IAuthService _auth = new authService();
        //login controller
        [HttpGet]
        [Route("login")]
        public string login(loginDto dto)
        {
            if (_auth.login(dto) == null)
            {
                //return http status code 401
                return "401";
            }
            else
            {
                return _auth.login(dto);
            }
        }
    }
}
