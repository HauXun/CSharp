using System;
using static System.Console;

namespace Exercise_6
{
	abstract class SinhVienPoly
	{
		string hoTen;
		string nganh;

		public SinhVienPoly()
		{

		}

		public SinhVienPoly(string hoTen, string nganh)
		{
			this.hoTen = hoTen;
			this.nganh = nganh;
		}

		abstract public double getDiem();
	}
}
