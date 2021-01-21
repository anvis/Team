using DataLayer.Models;
using DomainEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface ITournamentRepository
    {
        List<Tournament_DL> CreateTournaments();
    }
}
