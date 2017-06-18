using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RugbyManager2017.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PlayerContext(serviceProvider.GetRequiredService<DbContextOptions<PlayerContext>>()))
            {
                if (context.Players.Any())
                {
                    return;
                }

                context.Players.AddRange(
                    new Player
                    {
                        PlayerName = "Stephen Jones",
                        PlayerSkill = 16,
                        PlayerPosition = 10
                    },
                    new Player
                    {
                        PlayerName = "Sam Warburton",
                        PlayerSkill = 17,
                        PlayerPosition = 7
                    }                    
                );
                context.SaveChanges();
            }
        }
    }
}
