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
                    //Scarlets
					new Player { PlayerName = "Johnny Mcnicholl", PlayerSkill = 14, PlayerPosition = 15, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "Liam Williams", PlayerSkill = 17, PlayerPosition = 14, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "Jonathan Davies", PlayerSkill = 17, PlayerPosition = 13, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "Scott Williams", PlayerSkill = 16, PlayerPosition = 12, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "Steff Evans", PlayerSkill = 15, PlayerPosition = 11, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "Rhys Patchell", PlayerSkill = 14, PlayerPosition = 10, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "Gareth Davies", PlayerSkill = 16, PlayerPosition = 9, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "John Barclay", PlayerSkill = 16, PlayerPosition = 8, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "James Davies", PlayerSkill = 15, PlayerPosition = 7, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "Aaron Shingler", PlayerSkill = 15, PlayerPosition = 6, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "Tadhg Beirne", PlayerSkill = 15, PlayerPosition = 5, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "Lewis Rawlins", PlayerSkill = 13, PlayerPosition = 4, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "Samson Lee", PlayerSkill = 16, PlayerPosition = 3, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "Ryan Elias", PlayerSkill = 14, PlayerPosition = 2, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "Rob Evans", PlayerSkill = 16, PlayerPosition = 1, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "Emyr Phillips", PlayerSkill = 14, PlayerPosition = 16, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "Wyn Jones", PlayerSkill = 14, PlayerPosition = 17, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "Werner Kruger", PlayerSkill = 13, PlayerPosition = 18, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "David Bulbring", PlayerSkill = 13, PlayerPosition = 19, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "Will Boyde", PlayerSkill = 14, PlayerPosition = 20, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "Jonathan Evans", PlayerSkill = 13, PlayerPosition = 21, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "Hadleigh Parkes", PlayerSkill = 13, PlayerPosition = 22, PlayerTeam = "Scarlets" },
					new Player { PlayerName = "DTH van der Merwe", PlayerSkill = 13, PlayerPosition = 23, PlayerTeam = "Scarlets" } 
                    //Munster

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
