using apihookup.interfaces;
using apihookup.service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apihookup.Controllers
{
    [Route("[controller]")]
    public class LogController : ControllerBase
    {
        private ILogService _logService;

        public LogController(ILogService logService )
        {
            _logService = logService;
        }
        [Authorize]
        [HttpGet]
        [Route("GetAllLogs")]
        public IActionResult GetAllLogs()
        {
            try
            {
                return Ok(_logService.getAllLogs());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [Authorize]
        [HttpGet("getLogById")]
        public IActionResult GetLogsByHookupId(int id)
        {
            try
            {
                return Ok(_logService.getLogsByHookupId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Authorize]
        [HttpDelete]
        [Route("DeleteLogsByHookupId")]
        public IActionResult DeleteLogsByHookupId(int id)
        {
            try
            {
                _logService.deleteLogsByHookupId(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [Authorize]
        [HttpDelete("deleteLogById")]
        public IActionResult DeleteLogById(int id)
        {
            try
            {
                _logService.deleteLogById(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
