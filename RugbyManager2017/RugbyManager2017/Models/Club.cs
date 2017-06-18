using System;

namespace RugbyManager2017.Models
{
    public class Club : Teams
    {
        public long Id { get; set; }
        public string ClubName { get; set; }
        public Player[] teamSheet;
        //competition

        public Club(string name)
        {
            this.ClubName = name;
            this.teamSheet = new Player[23];
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
            int teamSkill = 0;

            if (this.TeamSheetFull())
            {
                foreach (var player in teamSheet)
                {
                    teamSkill += player.PlayerSkill;
                }

            }
            return teamSkill;
		}

    }
}
