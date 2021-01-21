using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseInMemoryDatabase("TeamDB", null); // ("Server=IN1-1024735LT\\ANVISERVER;Database=Screener;User ID=sa;Password=Anvi@4545");
            }
        }


        public DbSet<Configurations> Configurations { get; set; }

        public DbSet<Player> Player { get; set; }

        public DbSet<Team> Team { get; set; }
        public DbSet<Tournment> Tournment { get; set; }
    }
}
