using System;

namespace QuanLyNongTrai
{
	class Grass : Food
	{
		/// <summary>
		/// Initial value for grass
		/// </summary>
		public Grass()
		{
			Name = Constant.GRASS_NAME;
			Price = Constant.GRASS_PRICE;
		}
	}
}