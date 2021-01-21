using System;
using System.Collections.Generic;
using System.Text;

namespace DomainEntity
{
   public class Team_DL
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string TournmentCode { get; set; }
        public string JerseyColor { get; set; }
        public List<Player_DL> Players { get; set; }
    }
}
