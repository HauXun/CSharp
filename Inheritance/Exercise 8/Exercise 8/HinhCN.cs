using System;
using static System.Console;

namespace Exercise_8
{
	class HinhCN : Hinh, Son
	{
		double canhA;
		double canhB;

		public HinhCN()
		{

		}

		public HinhCN(double canhA, double canhB)
		{
			this.canhA = canhA;
			this.canhB = canhB;
		}

		// Hàm tính diện tích HCN
		public override double TinhDT() => canhA * canhB;

		// Hàm tính chi phí sơn
		public double TinhChiPhiSon(double dienTich) => 80000 * dienTich;
	}
}
