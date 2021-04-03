using System;
using static System.Console;

namespace Exercise_4
{
	class Animal
	{
		public int Legs { get; set; }
		public float Width { get; set; }

		public Animal()
		{
			WriteLine("Khoi tao Animal");
		}

		public Animal(string abc)
		{
			WriteLine("Khoi tao Animal (2) - {0}", abc);
		}

		public void ShowLegs()
		{
			WriteLine($"Legs: {Legs}");
		}
	}
}
