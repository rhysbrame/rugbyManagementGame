using System;
namespace RugbyManagementGameV1.Properties
{
    public class Player
    {
        private string player;

        public string PlayerClassName
        {
            get
            {
                return player;
            }
        }

        public int PlayerClassSkill { get; set; }

        public Player(string playerParameterName, int playerParameterSkill)
        {
            this.player = playerParameterName;
            this.PlayerClassSkill = playerParameterSkill;
        }
    }
}
