using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using IRobo.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IRobo.Controllers
{
    [Route("api/rest/mars")]
    [ApiController]
    public class MarsController : ControllerBase
    {
        [HttpGet("{command}")]
        public ActionResult Get(string command)
        {
            Bot bot = new Bot();

            if(bot.ValidCommand(command))
                return StatusCode(StatusCodes.Status400BadRequest, "Bad Request");

            try
            {
                var moviment = bot.Action(command);
                return Ok(moviment);
            }
            catch
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Bad Request");
            }
        }

    }
}
