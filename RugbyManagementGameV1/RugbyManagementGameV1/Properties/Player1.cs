using System;
namespace RugbyManagementGameV1.Properties
{
    public class Player
    {
        public string PlayerClassName { get; set; }
        public int PlayerClassSkill { get; set; }

        public Player(string playerParameterName, int playerParameterSkill)
        {
            this.PlayerClassName = playerParameterName;
            this.PlayerClassSkill = playerParameterSkill;
        }
    }
}
