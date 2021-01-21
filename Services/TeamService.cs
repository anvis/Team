using AutoMapper;
using DomainEntity;
using EntityLayer;
using Repository.Utility;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
