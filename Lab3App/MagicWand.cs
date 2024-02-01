using System;
namespace Lab3App
{
	public class MagicWand : Tool
	{
		public MagicWand(string name)
		{
            Description = name;
		}

        public override void Display()
        {
            Console.WriteLine("MagicWand " + Description + " is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");
        }
    }
}

