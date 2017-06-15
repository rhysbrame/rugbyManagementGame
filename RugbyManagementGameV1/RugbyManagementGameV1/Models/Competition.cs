using System;
namespace RugbyManagementGameV1.Models
{
    public class Competition
    {
        public string CompetitionClassName { get; set; }
        public string CompetitionClassLayout { get; set; }

        public Competition(string competitionParameterName, string competitionParameterLayout)
        {
            this.CompetitionClassName = competitionParameterName;
            this.CompetitionClassLayout = competitionParameterLayout;
        }
    }
}
