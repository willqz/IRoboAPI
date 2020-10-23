using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using IRobo.Domain;
using IRobo.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IRobo.Controllers
{
    [Route("api/rest/marsangular")]
    [ApiController]
    public class MarsAngularController : ControllerBase
    {
        [HttpGet("{command}")]
        [EnableCors("AllowOrigin")]
        public ActionResult MarsAngular(string command)
        {
            Bot bot = new Bot();

            if(!bot.ValidCommand(command))
                return StatusCode(StatusCodes.Status400BadRequest, "Bad Request");

            try
            {
                var moviment = bot.Action(command);

                return Ok(new Moviment { Coords = moviment });
            }
            catch
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Bad Request");
            }
        }

    }
}
