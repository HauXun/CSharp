using System;

namespace QuanLyNongTrai
{
	class Chicken : FarmingAnimal
	{
		/// <summary>
		/// Get or set value for Chicken
		/// </summary>
		public Chicken()
		{
			Name = Constant.CHICKEN_NAME;
			EatFood = new Corn();
		}
	}
}