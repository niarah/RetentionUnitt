using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetentionUnit.Models;
using RetentionUnit.Models.Db;
using System.Text.Json;

namespace RetentionUnit.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SearchClientController : ControllerBase
    {
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(new ClientInfo { errorMessage = "only post request allowed" }) { StatusCode = StatusCodes.Status400BadRequest };
        }

        [HttpPost]
        public JsonResult Post([FromBody] JsonElement requestJson)
        {
            try
            {
                string requestJsonString = JsonSerializer.Serialize(requestJson);
                DbQueries db = new DbQueries();
                return new JsonResult(db.GetClientInfo(requestJsonString));
            }
            catch(Exception E)
            {
                return new JsonResult(new ClientInfo { errorMessage = E.ToString() }) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}