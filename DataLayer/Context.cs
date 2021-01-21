using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public  class TeamContext : DbContext
    {
        public TeamContext()
        {
        }

        public TeamContext(DbContextOptions<TeamContext> options)
            : base(options)
        {
        }

        public DbSet<Configurations> Configurations { get; set; }

        public DbSet<Player> Player { get; set; }

        public DbSet<Team> Team { get; set; }
        public DbSet<Tournment> Tournment { get; set; }
    }
}
