using System;
namespace Lab3App
{
	public class CollectionBoard
	{
		private int totalScore;
		private int totalValue;

        public int TotalScore
        {
            get { return totalScore; } // Getter
            set { totalScore = value; } // Setter
        }

        public int TotalValue
        {
            get { return totalValue; } // Getter
            set { totalValue = value; } // Setter
        }

        public CollectionBoard()
		{
		}
	}
}

