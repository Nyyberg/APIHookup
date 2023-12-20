using apihookup.dto;
using apihookup.interfaces;
using apihookup.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apihookup.Controllers
{
    public class hookupController : ControllerBase
    {
        private IHookupRepo _repo;
        private IMapper _mapper;
        public hookupController(IHookupRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
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
            throw new NotImplementedException();
        }

        //add a hookup
        [Authorize]
        [HttpPost("addHookup")]
        public IActionResult AddHookup(HookupDto dto)
        {
            throw new NotImplementedException();
        }

        //add a body
        [Authorize]
        [HttpPost("addBody")]
        public IActionResult AddBody(Body dto)
        {
            throw new NotImplementedException();
        }

        //add a header
        [Authorize]
        [HttpPost("addHeader")]
        public IActionResult AddHeader(Header dto)
        {
            throw new NotImplementedException();
        }

        //get all hookups
        //as special dto with url, method type, id and interval
        [Authorize]
        [HttpGet("getAllHookups")]
        public IActionResult GetAllHookups()
        {
            throw new NotImplementedException();
        }

        //get a hookubBe by id with all bodies and headers
        [Authorize]
        [HttpGet("getHookupById")]
        public IActionResult GetHookupById(int id)
        {
            throw new NotImplementedException();
        }

        //update a body
        [Authorize]
        [HttpPut("updateBody")]
        public IActionResult UpdateBody(Body dto)
        {
            throw new NotImplementedException();
        }

        //update a header
        [Authorize]
        [HttpPut("updateHeader")]
        public IActionResult UpdateHeader(Header dto)
        {
            throw new NotImplementedException();
        }
    }
}
