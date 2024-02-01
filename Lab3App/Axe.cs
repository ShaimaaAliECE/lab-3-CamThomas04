using System;
namespace Lab3App
{
	public class Axe : Tool
	{
		public Axe(string name)
		{
            Description = name;
		}

        public override void Display()
        {
            Console.WriteLine("Axe " + Description + " is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }
    }
}

