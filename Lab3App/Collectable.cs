using System;
using System.Collections.Generic;
namespace Lab3App
{
	public abstract class Collectable : Displayable
	{
		private CollectionBoard board;

		public CollectionBoard Board
		{
			get { return board; }
			set { board = value;  }
		}

		private string description;

        public string Description
        {
            get { return description; } // Getter
            set { description = value; } // Setter
        }

        public Collectable()
		{
		}

        public abstract void Display();

		public virtual void AddMe(List<Collectable> list)
		{
			Console.WriteLine(Description + " Collected, Congrats!!!!");
			list.Add(this);
		}
    }
}

