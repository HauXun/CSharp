using System;

namespace QuanLyNongTrai
{
	class Pig : FarmingAnimal
	{
		/// <summary>
		/// Get or set value for Chicken
		/// </summary>
		public Pig()
		{
			Name = Constant.PIG_NAME;
			EatFood = new Bran();
		}
	}
}