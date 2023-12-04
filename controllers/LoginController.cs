using ApiHookup.Dto;
using ApiHookup.Interfaces;
using ApiHookup.services;
using Microsoft.AspNetCore.Mvc;

namespace ApiHookup.controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        //http get with username and password
        [HttpGet]
        [Route("api/login/{dto}")]
        public ActionResult<string> Login(loginDto dto)
        {
            IAuthService authService = new AuthService();
            var result = authService.Login(dto);
            if (result == null)
            {
                return BadRequest("Invalid login");
            }
            return Ok(result);
        }
    }
}
