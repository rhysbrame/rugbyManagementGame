using System;

namespace RugbyManager2017.Models
{
	public class Game
	{
		public Club homeTeam { get; set; }
		public Club awayTeam { get; set; }

		public Game(Club homeParameterTeam, Club awayParameterTeam)
		{
			this.homeTeam = homeParameterTeam;
			this.awayTeam = awayParameterTeam;
		}

		public double CalculateWinnerRange()
		{
			double homeValue = this.homeTeam.CalculateTeamSkill();
			double awayValue = this.awayTeam.CalculateTeamSkill();

			double divisor = homeValue + awayValue;

			double range = homeValue / divisor;
			return Math.Round(range, 2);
		}

		public String CalculateWinner()
		{
			Random randomIndex = new Random();
			double identifier = Math.Round(randomIndex.NextDouble(), 2);
			double drawCoeff = 0.02;//2016 rugby season has av of 5% of drawn games

			Console.Write(identifier);
			Console.Write(this.CalculateWinnerRange());

			if (identifier < (this.CalculateWinnerRange() - drawCoeff))
			{
                return homeTeam.ClubName;
			}
			else if (identifier > (this.CalculateWinnerRange() + drawCoeff))
			{
				return awayTeam.ClubName;
			}
			else
			{
				return "Draw";
			}
		}

	}
}
