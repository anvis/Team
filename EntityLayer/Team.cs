using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string TournmentCode { get; set; }
        public string JerseyColor { get; set; }
        public List<Player> Players { get; set; }
    }
}
