using System;
namespace RugbyManagementGameV1.Models
{
    public class Team
    {
        public Player[] teamSheet;
        public string TeamClassName { get; set; }
        public int TeamClassSkill { get; set; }

        public Team(string teamParameterName, int teamParameterSkill)
        {
            this.teamSheet = new Player[15];
            this.TeamClassName = teamParameterName;
            this.TeamClassSkill = teamParameterSkill;
        }

        public int TeamSheetCount()
        {
            int count = 0;
            foreach (var player in teamSheet)
            {
                if (player != null)
                {
                    count++;
                }
            }
            return count;
        }

        public bool TeamSheetFull()
        {
            return this.TeamSheetCount() == this.teamSheet.Length;
        }

		public void AddPlayer(Player player)
		{
			if (this.TeamSheetFull())
			{
				return;
			}
			int teamSheetIndex = this.TeamSheetCount();
            this.teamSheet[teamSheetIndex] = player;
		}

        public int CalculateTeamSkill()
        {
            if (this.TeamSheetCount() < this.teamSheet.Length)
            {
                return 0; //how can i break out of a method??
            }
			
            int teamSkill = 0;
			foreach (var player in teamSheet)
			{
                teamSkill += player.PlayerClassSkill; 
			}
			return teamSkill;
        }


     }
 }

