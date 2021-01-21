using System.Collections.Generic;

namespace DataLayer.Models
{
    public class Tournment
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string TournmentCode { get; set; }

        public int ConfigurationId { get; set; }

        public List<Team> Teams { get; set; }
    }
}
