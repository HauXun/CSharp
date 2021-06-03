using System;

namespace QuanLyNongTrai
{
	class DairyCow : FarmingAnimal
	{
		/// <summary>
		/// Get or set value for DairyCow
		/// </summary>
		public DairyCow()
		{
			Name = Constant.DAIRY_COW_NAME;
			EatFood = new Grass();
		}
	}
}