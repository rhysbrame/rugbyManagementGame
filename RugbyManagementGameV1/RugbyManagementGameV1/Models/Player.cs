using System;

namespace RugbyManagementGameV1.Models
{
	public class Player
	{
		public string PlayerClassName { get; set; }
        public int PlayerClassPosition { get; set; }
		public int PlayerClassSkill { get; set; }

		public Player(string playerParameterName, int playerParameterPosition, int playerParameterSkill)
		{
			this.PlayerClassName = playerParameterName;
            this.PlayerClassPosition = playerParameterPosition;
			this.PlayerClassSkill = playerParameterSkill;
		}
	}
}
