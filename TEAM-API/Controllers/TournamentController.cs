using DataLayer.Models;
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
    public class TournamentController : ControllerBase
    {
        private readonly ILogger<TournamentController> _logger;
        private readonly ITournamentService _tournamentService;
        public TournamentController(ILogger<TournamentController> logger, ITournamentService tournamentService)
        {
            _logger = logger;
            _tournamentService = tournamentService;

            //test checkin
        }

        public async Task<ActionResult<IEnumerable<Tournment>>> Get()
        {
           var tournmemnt= _tournamentService.GetTournaments();
            return Ok(tournmemnt);
        }

    }
}
