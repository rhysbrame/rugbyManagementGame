using System;
namespace RugbyManagementGameV1.Models
{
    public class Team
    {
        public string TeamClassName { get; set; }
        public int TeamClassSkill { get; set; }

        public Team(string teamParameterName, int teamParameterSkill)
        {
            this.TeamClassName = teamParameterName;
            this.TeamClassSkill = teamParameterSkill;
        }
    }
}
