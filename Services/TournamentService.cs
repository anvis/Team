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

        public List<Tournament> CreateTournaments()
        {
            List<Tournament_DL> stockDetailsDTOs = repo.TournamentRepository.CreateTournaments();

            //  return MapperProfile.MapList<StockDetailsDTO, StockDetails>(_mapper, stockDetailsDTOs);
            return null;
        }
    }
}
