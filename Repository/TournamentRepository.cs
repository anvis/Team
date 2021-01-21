using DataLayer.Models;
using DomainEntity;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class TournamentRepository: BaseRepository<Tournment> , ITournamentRepository
    {
        public List<Tournament_DL> CreateTournaments()
        {          
            List<Tournment> tournments = new List<Tournment>();



            tournments.Add( new Tournment
               {
                Name = "IPL League",
                TournmentCode = "IPL2021",
                ConfigurationId = 1,
                Teams = null
            });

            tournments.Add(new Tournment
            {
                Name = "PRO League",
                TournmentCode = "PRO2021",
                ConfigurationId = 1,
                Teams = null
            });


            List<Tournament_DL> tournament_DLs = new List<Tournament_DL>();


            foreach (var item in tournments)
            {
                Repository.Insert(item);                

                tournament_DLs.Add(new Tournament_DL
                {
                    ConfigurationId = item.ConfigurationId,
                    Name = item.Name,
                    TournmentCode = item.TournmentCode
                });
            }
            Repository.SaveAllChanges();
            getTournments();
            return tournament_DLs;
        }

        public void getTournments()
        {
            var watchListList = Repository.GetAll();
        }

       
    }
}
