using System;
namespace RugbyAPI.Models
{
    public class PracticeClass
    {
		public int ID { get; set; }
		public string Name { get; set; }
		public DateTime BirthDate { get; set; }
		public int Skill { get; set; }
        //public enum Positon { get; set; }


        public PracticeClass()
        {
        }
    }
}
