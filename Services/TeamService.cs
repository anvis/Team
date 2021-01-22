using AutoMapper;
using DomainEntity;
using EntityLayer;
using Repository.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Services
{
  public  class TeamService : ITeamService
    {
        Repo repo = new Repo();
        private IMapper _mapper;

        public TeamService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Team CreateTeam(Team team)
        {
            var teamobj = _mapper.Map<Team, Team_DL>(team);
            Team_DL teamDetails = repo.TeamRepository.CreateTeam(teamobj);
            return MapperProfile.Map<Team_DL, Team>(_mapper, teamDetails);
        }

        public bool ValidateTeam(Team team)
        {

            List<Team_DL> teamslIst = repo.TeamRepository.GetTeams();
            if (teamslIst.Any(s => s.TournmentCode.Equals(team.TournmentCode) && s.TeamName.Equals(team.TeamName)))
                return false;
            else
                return true;

           
        }
    }
}
