using AutoMapper;
using EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TEAM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private ITeamService _teamService;
        private IMapper _mapper;

        private readonly ILogger<TeamsController> _logger;
       
        public TeamsController(ILogger<TeamsController> logger, ITeamService teamService)
        {
            _logger = logger;
            _teamService = teamService;
        }

        [HttpPost]
        [Route("Team")]
        public ActionResult<Team> CreateTeam(Team team)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Validation Failed");
                }

                if (!_teamService.ValidateTeam(team))
                {
                    return BadRequest("Team with same name is already registered in this tournament");
                }
                return  Ok(_teamService.CreateTeam(team));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
     