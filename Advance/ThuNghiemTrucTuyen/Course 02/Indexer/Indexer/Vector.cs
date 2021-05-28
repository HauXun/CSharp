using System;
using static System.Console;

namespace Indexer
{
	class Vector
	{
		private double x;
		private double y;

		public Vector()
		{

		}

		public Vector(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		public void Info() => WriteLine($"x = {x}, y = {y}");

		public double this[int i]
		{
			get
			{
				switch (i)
				{
					case 0:
						return x;
					case 1:
						return y;
					default:
						throw new Exception("Sai chi so");
				}
			}
			set
			{
				switch (i)
				{
					case 0:
						x = value;
						break;
					case 1:
						y = value;
						break;
					default:
						throw new Exception("Sai chi so");
				}
			}
		}

		public double this[string s]
		{
			get
			{
				switch (s)
				{
					case "toadox":
						return x;
					case "toadoy":
						return y;
					default:
						throw new Exception("Sai chi so");
				}
			}
			set
			{
				switch (s)
				{
					case "toadox":
						x = value;
						break;
					case "toadoy":
						y = value;
						break;
					default:
						throw new Exception("Sai chi so");
				}
			}
		}
	}
}
