using System;
using Microsoft.EntityFrameworkCore;

namespace RugbyManager2017.Models
{
    public class ClubContext : DbContext
    {
        public ClubContext(DbContextOptions<ClubContext>options) : base(options)
        {
        }

        public DbSet<Club> Clubs { get; set; }
    }
}
