using System;

namespace QuanLyNongTrai
{
	class Corn : Food
	{
		/// <summary>
		/// Initial value for grass
		/// </summary>
		public Corn()
		{
			Name = Constant.CORN_NAME;
			Price = Constant.CORN_PRICE;
		}
	}
}