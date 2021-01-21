using AutoMapper;
using DomainEntity;
using EntityLayer;
using Repository.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
   public class TournamentService:ITournamentService
    {
        Repo repo = new Repo();
        private IMapper _mapper;

        public TournamentService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<Tournament> CreateTournaments()
        {
            List<Tournament_DL> tournmentDetails = repo.TournamentRepository.CreateTournaments();
            return MapperProfile.MapList<Tournament_DL, Tournament>(_mapper, tournmentDetails);            
        }
    }
}
