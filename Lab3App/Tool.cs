using System;
using System.Collections.Generic;

namespace Lab3App
{
	public abstract class Tool : Collectable
	{
		public Tool()
		{
		}

		public override abstract void Display();

		public abstract void DoAction();

		public override void AddMe(List<Collectable> list)
		{
			base.AddMe(list);
			DoAction();
		}
	}
}

