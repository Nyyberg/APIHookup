using apihookup.interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apihookup.Controllers
{
    [Route("[controller]")]
    public class SqlTableController : ControllerBase
    {
        ISqlTableRepo _tablerepo;
        public SqlTableController(ISqlTableRepo tablerepo) {
            _tablerepo = tablerepo;
        }


        // get all table names
        [Authorize]
        [HttpGet("getTables")]
        public IActionResult GetTables()
        {
            try
            {
                return Ok(_tablerepo.GetAllTables());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // get all columns for a table
        [Authorize]
        [HttpGet("getColumns")]
        public IActionResult GetColumns(string tableName)
        {
            try
            { 
                return Ok(_tablerepo.GetColumnsOfTable(tableName));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
