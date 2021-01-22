using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
 public   interface ITeamService
    {
        Team CreateTeam(Team team);
        bool ValidateTeam(Team team);
    }
}
