﻿using System;
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
	                    PlayerSkill = 2,
	                    PlayerPosition = 13
                    },
					new Player
                    {
						PlayerName = "Eddie Jones",
						PlayerSkill = 13,
						PlayerPosition = 3
                    }                                    
                );

                context.SaveChanges();
            }

			using (var context = new ClubContext(serviceProvider.GetRequiredService<DbContextOptions<ClubContext>>()))
			{
				if (context.Clubs.Any())
				{
					return;
				}

				context.Clubs.AddRange(
					new Club { ClubName = "Scarlets" },
					new Club { ClubName = "Hurricanes" }
                );

				context.SaveChanges();
			}


		}
    }
}
