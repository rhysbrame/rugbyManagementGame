using System;
using Microsoft.EntityFrameworkCore;

namespace RM17.Models
{
    public class TeamContext : DbContext
    {
        public TeamContext() {

        }
        
        public TeamContext(DbContextOptions<TeamContext>options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseNpgsql("host=localhost; database=rugbymanager");
        }

        public DbSet<Team> Teams { get; set; }
    }
}
