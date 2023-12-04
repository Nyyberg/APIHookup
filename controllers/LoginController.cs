using apihookup.dto;
using Microsoft.AspNetCore.Mvc;

namespace apihookup.Controllers
{
    public class loginController : ControllerBase
    {
        //login controller
        [HttpGet]
        public string login(loginDto dto)
        {
            return "login";
        }
    }
}
