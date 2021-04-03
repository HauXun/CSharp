using System;
using static System.Console;

namespace Exercise_6
{
	class SinhVienIT : SinhVienPoly
	{
		double diemC;
		double diemHTML;

		// Override phương thức trừu tượng
		public override double getDiem() => (diemC * 2 + diemHTML) / 3;
	}
}
