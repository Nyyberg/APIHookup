﻿using apihookup.interfaces;
using apihookup.repository;
using Microsoft.AspNetCore.Mvc;

namespace apihookup.Controllers
{
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        ICustomSqlRepo _repo;
        public TestController(ICustomSqlRepo repo)
        {
            _repo = repo;
        }

        [HttpPost]
        [Route("tryQuery")]
        public IActionResult TryQuery([FromBody] string query)
        {
            try
            {
                return Ok(_repo.executeQuery(query));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
