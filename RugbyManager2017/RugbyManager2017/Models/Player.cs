using System;

namespace RugbyManager2017.Models
{

    public class Player
    {
		public long Id { get; set; }
        public string PlayerName { get; set; }
        public int PlayerPosition { get; set; }
        public int PlayerSkill { get; set; }
        public string PlayerTeam { get; set; }
        public Club PlayerClub { get; set; }
        public Nation PlayerNation { get; set; }

    }



}
