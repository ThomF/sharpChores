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

        [HttpGet("{id}")]
        public ActionResult<Chore> GetOneChore(int id)
        {
            try 
            {
            Chore chore = _choresService.GetOneChore(id);
            return Ok(chore);
            }
            catch (Exception e)
            {
            return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
        {
            try 
            {
            Chore chore = _choresService.CreateChore(choreData);
            return Ok(chore);
            }
            catch (Exception e)
            {
            return BadRequest(e.Message);
            }
        }

        [HttpDelete("{choreId}")]
        public ActionResult<string> RemoveChore(int choreId)
        {
        try 
        {
        string message = _choresService.RemoveChore(choreId);
            return Ok(message);
        }
        catch (Exception e)
        {
        return BadRequest(e.Message);
        }
        }

        [HttpPut("{id}/done")]
        public ActionResult<Chore> FinishChore(int id)
        {
            try 
            {
            Chore chore = _choresService.FinishChore(id);
            return Ok(chore);
            }
            catch (Exception e)
            {
            return BadRequest(e.Message);
            }
        }
    }
