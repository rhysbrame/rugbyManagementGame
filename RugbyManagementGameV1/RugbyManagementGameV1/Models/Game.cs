using System;

namespace RugbyManagementGameV1.Models
{
    public class Game
    {
        public Team homeTeam { get; set; }
        public Team awayTeam { get; set; }

		public Game(Team homeParameterTeam, Team awayParameterTeam)
        {
            this.homeTeam = homeParameterTeam;
            this.awayTeam = awayParameterTeam;
        }

        public double CalculateWinnerRange()
        {
            double homeValue = this.homeTeam.TeamClassSkill;
            double awayValue = this.awayTeam.TeamClassSkill;

            double divisor = homeValue + awayValue;

            double range = homeValue / divisor;
            return Math.Round(range, 2);
        }

        public String CalculateWinner() 
        {
            Random randomIndex = new Random();
            double identifier = Math.Round(randomIndex.NextDouble(),2);
            double drawCoeff = 0.02;//2016 rugby season has av of 5% of drawn games

            Console.Write(identifier);
            Console.Write(this.CalculateWinnerRange());

            if ( identifier < (this.CalculateWinnerRange() - drawCoeff))
            {
                return homeTeam.TeamClassName;
            }
            else if (identifier > (this.CalculateWinnerRange() + drawCoeff))
            {
                return awayTeam.TeamClassName;
            }
            else 
            {
                return "Draw";
            }
        } 

    }
}
