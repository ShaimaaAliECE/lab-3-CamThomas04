using System;
using System.Collections.Generic;

namespace Lab3App
{
	public class Coin : Treasure
	{
        private int value;

        public int Value
        {
            get { return value;  }
            set { this.value = value;  }
        }

		public Coin(string name, int score, int value)
		{
            Description = name;
            Score = score;
            Value = value;
		}

        public override void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue += Value;
            Console.WriteLine("Total Value is updated to: " + Board.TotalValue);
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
        }
    }
}

