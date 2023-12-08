using apihookup.dto;
using apihookup.interfaces;
using apihookup.service;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace apihookup.Controllers
{
    [Route("[controller]")]
    public class loginController : ControllerBase
    {
        IAuthService _auth;

        public loginController(IAuthService auth)
        {
            _auth = auth;
        }

        //login controller
        [HttpPost("login")]
        public IActionResult Login([FromBody] loginDto dto)
        {
            try
            {
                return Ok(_auth.login(dto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
    }
