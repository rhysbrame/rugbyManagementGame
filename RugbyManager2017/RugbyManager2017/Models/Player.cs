using System;

namespace RugbyManager2017.Models
{

    public class Player
    {
		public long Id { get; set; }
        public string PlayerName { get; set; }
        public int PlayerPosition { get; set; }
        public int PlayerSkill { get; set; }

        public Player(string name, int position, int skill)
        {
            this.PlayerName = name;
            this.PlayerPosition = position;
            this.PlayerSkill = skill;
        }
    }

}
