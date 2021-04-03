using System;
using static System.Console;

namespace Exercise_1
{
	class Animal
	{
		protected double Weight;
		protected double Height;
		protected static int Legs;

		public void Info()
		{
			WriteLine("Weight: " + Height + " Height: " + Height + " Legs: " + Legs);
		}

		public Animal()
		{

		}

		public Animal(double w, double h, int l)
		{
			Weight = w;
			Height = h;
			Legs = l;
		}
	}

	class Cat : Animal
	{
		public Cat()
		{
			Weight = 500;
			Height = 20;
			Legs = 2;
		}

		public Cat(double w, double h, int l) : base(w, h, l)
		{

		}

		public new void Info()
		{
			WriteLine("Info of cat: ");
			base.Info();
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Cat BlackCat = new Cat();
			BlackCat.Info();
		}
	}
}
