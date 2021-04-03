using System;
using static System.Console;

namespace InitialBaseClass
{
	class Table : Rectangle
	{
		public Table(int width, int height) : base (width, height)
		{

		}

		public double GetCost()
		{
			double cost;
			cost = GetArea();
			return cost;
		}

		public new void Display()
		{
			base.Display();
			WriteLine("Cost: {0}", GetCost());
		}
	}
}
