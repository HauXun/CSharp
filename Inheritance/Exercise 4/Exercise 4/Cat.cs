using System;
using static System.Console;

namespace Exercise_4
{
	class Cat : Animal
	{
		public string food;

		public Cat(string s) : base (s)
		{
			this.Legs = 4;
			this.food = "Mouse";
			WriteLine("Khoi tao Cat");
		}

		public void Eat()
		{
			WriteLine(food);
		}

		public new void ShowLegs()
		{
			WriteLine($"Loai meo co: {Legs} chan");
		}

		public void ShowInfo()
		{
			base.ShowLegs();
			ShowLegs();
		}
	}
}
