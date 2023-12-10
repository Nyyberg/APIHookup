using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apihookup.Controllers
{
    public class hookupController : ControllerBase
    {

        public hookupController()
        {

        }

        //get all registered hookups
        //TODO: implement get all hookups
        [Authorize]
        [HttpGet("getHookups")]
        public IActionResult GetHookups()
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //register a new hookup
        //TODO: implement register a new hookup
        [Authorize]
        [HttpPost("registerHookup")]
        public IActionResult RegisterHookup()
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //remove a hookup
        //TODO: implement remove a hookup
        [Authorize]
        [HttpDelete("removeHookup")]
        public IActionResult RemoveHookup()
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //update a hookup
        //TODO: implement update a hookup
        [Authorize]
        [HttpPut("updateHookup")]
        public IActionResult UpdateHookup()
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
