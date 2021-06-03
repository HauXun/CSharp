using System;

namespace QuanLyNongTrai
{
	class FarmingAnimal
	{
		private string name;
		private Food eatFood;

		/// <summary>
		/// Get or set value for name
		/// </summary>
		public string Name { get => name; set => name = value; }

		/// <summary>
		/// Get or set food that farming animal eat
		/// </summary>
		internal Food EatFood { get => eatFood; set => eatFood = value; }
	}
}