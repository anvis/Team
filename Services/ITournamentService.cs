﻿using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ITournamentService
    {
        List<Tournment> GetTournaments();
    }
}
