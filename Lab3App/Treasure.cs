using System;
using System.Collections.Generic;

namespace Lab3App
{
	public abstract class Treasure : Collectable
	{
		private int score;

		public int Score
		{
			get { return score; }
			set { score = value; }
		}

		public Treasure()
		{
		}

		public void UpdateTotalScore()
		{
			Board.TotalScore += Score;
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
        }

        public abstract override void Display();

        public override void AddMe(List<Collectable> list)
		{
			base.AddMe(list);
			UpdateTotalScore();
		}
	}
}

