using System;

namespace RugbyManager2017.Models
{

    public class Player
    {
		public long Id { get; set; }
		public bool IsComplete { get; set; }
        public string PlayerClassName { get; set; }
        public int PlayerClassPosition { get; set; }
        public int PlayerClassSkill { get; set; }
    }

}
