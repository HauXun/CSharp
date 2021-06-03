using System;

namespace QuanLyNongTrai
{
	class Dog : FarmingAnimal
	{
		/// <summary>
		/// Get or set value for Dog
		/// </summary>
		public Dog()
		{
			Name = Constant.DOG_NAME;
			EatFood = new Meat();
		}
	}
}