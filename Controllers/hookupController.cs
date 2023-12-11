using apihookup.dto;
using apihookup.interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apihookup.Controllers
{
    public class hookupController : ControllerBase
    {
        IHookupRepo _repo;
        public hookupController(IHookupRepo repo)
        {
            _repo = repo;
        }

        //get all registered hookups
        //TODO: implement get all hookups
        [Authorize]
        [HttpGet("getHookups")]
        public IActionResult GetHookups()
        {
            try
            {
                return Ok(_repo.GetHookups());
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
        public IActionResult RegisterHookup([FromBody] HookupDto dto)
        {
            try
            {
                return Ok(_repo.RegisterHookup(dto));
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
        public IActionResult RemoveHookup(int id)
        {
            try
            {
                return Ok(id);
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
        public IActionResult UpdateHookup(HookupDto dto)
        {
            try
            {
                return Ok(_repo.UpdateHookup(dto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
