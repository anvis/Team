using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public  class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Configurations> Configurations { get; set; }

        public DbSet<Player> Player { get; set; }

        public DbSet<Team> Team { get; set; }
        public DbSet<Tournment> Tournment { get; set; }
    }
}
