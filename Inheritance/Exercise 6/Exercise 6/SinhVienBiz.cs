using System;
using static System.Console;

namespace Exercise_6
{
	class SinhVienBiz : SinhVienPoly
	{
		double diemMar1;
		double diemMar2;

		public override double getDiem() => (diemMar1 + diemMar2) / 2;
	}
}
