using apihookup.dto;
using apihookup.interfaces;
using apihookup.service;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace apihookup.Controllers
{
    public class loginController : ControllerBase
    {
        IAuthService _auth = new authService();
        //login controller
        [HttpGet]
        [Route("login")]
        [HttpPost("login")]
        public IActionResult Login([FromBody] loginDto dto)
        {
            // Validate the loginDto
            if (string.IsNullOrEmpty(dto.username) || string.IsNullOrEmpty(dto.password))
            {
                return BadRequest("Username and password are required.");
            }
            var response = _auth.login(dto);
            // Perform authentication logic (e.g., check credentials against a database)
            if (response != null)
            {
                // Return a success message or token
                return Ok(response);
            }

            // Return an unauthorized status code
            return Unauthorized("Invalid credentials");
        }
    }
    }
