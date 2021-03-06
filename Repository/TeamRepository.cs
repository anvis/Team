﻿using DataLayer.Models;
using DomainEntity;
using System;
using System.Collections.Generic;

namespace Repository
{
  public  class TeamRepository : BaseRepository<Team>, ITeamRepository
    {
        public Team_DL CreateTeam(Team_DL teamDL)
        {
            List<Player> players = new List<Player>();
            foreach (var item in teamDL.Players)
            {
                players.Add(new Player { Gender = item.Gender, Id = item.Id, Name = item.Name, TeamId = item.TeamId });
            }

            Team team = new Team {  JerseyColor = teamDL.JerseyColor, Players = players,
             TeamName = teamDL.TeamName, TournmentCode = teamDL.TournmentCode };

            Repository.Insert(team);
            Repository.SaveAllChanges();
            teamDL.TeamId = team.TeamId;
            return teamDL;
        }

        public List<Team_DL> GetTeams()
        {
            var teamslist = Repository.GetAll();
            List<Team_DL> teams = new List<Team_DL>();
            foreach (var item in teamslist)
            {
                teams.Add(new Team_DL { TeamName = item.TeamName, TournmentCode = item.TournmentCode });
            }

            return teams;
        }
    }
}
