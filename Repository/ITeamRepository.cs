using DataLayer.Models;
using DomainEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
   public interface ITeamRepository
    {
        Team_DL CreateTeam(Team_DL team);
        List<Team_DL> GetTeams();
    }
}
