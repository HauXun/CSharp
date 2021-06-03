using System;

namespace QuanLyNongTrai
{
	class Meat : Food
	{
		/// <summary>
		/// Initial value for grass
		/// </summary>
		public Meat()
		{
			Name = Constant.MEAT_NAME;
			Price = Constant.MEAT_PRICE;
		}
	}
}