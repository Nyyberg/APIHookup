using apihookup.dto;
using apihookup.interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apihookup.Controllers
{
    public class hookupController : ControllerBase
    {
        private IHookupService _Service;
        public hookupController( IHookupService hookupService)
        {
            _Service = hookupService;
        }

        //remove a hookup
        //TODO: implement remove a hookup
        [Authorize]
        [HttpDelete("removeHookup")]
        public IActionResult RemoveHookup(int id)
        {
            try
            {
                _Service.RemoveHookup(id);
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
        public IActionResult UpdateHookup(HookupDto dto)
        {
            try
            {
                return Ok(_Service.UpdateHookup(dto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //add a hookup
        [Authorize]
        [HttpPost("addHookup")]
        public IActionResult AddHookup(HookupDto dto)
        {
            try
            {
                return Ok(_Service.AddHookup(dto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //add a body
        [Authorize]
        [HttpPost("addBody")]
        public IActionResult AddBody(BodyDto dto)
        {
            try
            {
                return Ok(_Service.AddBody(dto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //add a header
        [Authorize]
        [HttpPost("addHeader")]
        public IActionResult AddHeader(HeaderDto dto)
        {
            try
            {
                return Ok(_Service.AddHeader(dto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //get all hookups
        //as special dto with url, method type, id and interval
        [Authorize]
        [HttpGet("getAllHookups")]
        public IActionResult GetAllHookups()
        {
            try
            {
                return Ok(_Service.GetHookups());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //get a hookubBe by id with all bodies and headers
        [Authorize]
        [HttpGet("getHookupById")]
        public IActionResult GetHookupById(int id)
        {
            try
            {
                return Ok(_Service.GetHookupById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //update a body
        [Authorize]
        [HttpPut("updateBody")]
        public IActionResult UpdateBody(BodyDto dto)
        {
            try
            {
                return Ok(_Service.UpdateBody(dto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //update a header
        [Authorize]
        [HttpPut("updateHeader")]
        public IActionResult UpdateHeader(HeaderDto dto)
        {
            try
            {
                return Ok(_Service.UpdateHeader(dto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Authorize]
        [HttpGet("getAllCalenders")]
        public IActionResult GetAllCalenders(int id)
        {
            try
            {
                return Ok(_Service.GetAllCalenders(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Authorize]
        [HttpPost("addListOfCalender")]
        public IActionResult AddListOfCalender(List<IntervalDto> dtos)
        {
            try
            {
                return Ok(_Service.AddListOfCalender(dtos));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Authorize]
        [HttpPost("addSingleCalender")]
        public IActionResult AddSingleCalender(IntervalDto dto)
        {
            try
            {
                return Ok(_Service.AddSingleCalender(dto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [Authorize]
        [HttpDelete("removeCalender")]
        public IActionResult RemoveCalender(int id)
        {
            try
            {
                _Service.RemoveCalender(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
