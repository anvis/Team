using AutoMapper;
using DomainEntity;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TEAM_API.Dependencies
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Tournament_DL, Tournament>().ReverseMap();
            CreateMap<Team_DL, Team>().ReverseMap();
            CreateMap<Player_DL, Player>().ReverseMap();
        }
    }
}
