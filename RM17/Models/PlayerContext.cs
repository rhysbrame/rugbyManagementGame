using System;
using Microsoft.EntityFrameworkCore;

namespace RM17.Models
{
    public class PlayerContext : DbContext
    {
        public PlayerContext() {

        }

        public PlayerContext(DbContextOptions<PlayerContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseNpgsql("host=localhost; database=rugbymanager");
        }

        public DbSet<Player> Players { get; set; }

        //add migration
        //dotnet ef migrations add morestuff --context TeamContext / PlayerContext

        //apply migration
        //dotnet ef database update --context TeamContext / PlayerContext


    }
}

