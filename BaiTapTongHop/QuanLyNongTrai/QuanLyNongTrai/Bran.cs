using System;

namespace QuanLyNongTrai
{
	class Bran : Food
	{
		/// <summary>
		/// Initial value for grass
		/// </summary>
		public Bran()
		{
			Name = Constant.BRAN_NAME;
			Price = Constant.BRAN_PRICE;
		}
	}
}