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
                        PlayerClassName = "Stephen Jones",
                        PlayerClassSkill = 16,
                        PlayerClassPosition = 10
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
