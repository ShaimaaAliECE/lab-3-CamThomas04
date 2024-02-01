using System;
namespace Lab3App
{
	public class Diamond :Treasure
	{
		public Diamond(string name, int score)
		{
            Description = name;
            Score = score;
		}

        public override void Display()
        {
            Console.WriteLine("Diamond " + Description + " is displayed");
        }
    }
}

