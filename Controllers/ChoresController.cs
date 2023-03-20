using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sharpChores.Controllers;

    [ApiController]
    [Route("api/chores")]
    public class ChoresController : ControllerBase
    {
        private readonly ChoresService _choresService;

        public ChoresController(ChoresService choresService){
            _choresService = choresService;
        }

        [HttpGet]
        public ActionResult<List<Chore>> GetAllChores()
        {
            try 
            {
            return Ok(_choresService.GetAllChores());
            }
            catch (Exception e)
            {
            return BadRequest(e.Message);
            }
        }
    }
