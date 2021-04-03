using System;
using static System.Console;

namespace Exercise_9
{
	class HinhCN : Hinh
	{
		// Thuộc tinh
		double canhA;
		double canhB;


		// Phương thức
		public HinhCN()
		{

		}

		public HinhCN(double canhA, double canhB)
		{
			this.canhA = canhA;
			this.canhB = canhB;
		}

		public override void Nhap()
		{
			Write("Nhap canh 1: ");
			canhA = double.Parse(ReadLine());
			Write("Nhap canh 2: ");
			canhB = double.Parse(ReadLine());
		}

		// Hàm tính diện tích
		public override double TinhDT() => canhB * canhA;

		// Hàm tính chu vi
		public override double TinhCV() => (canhA + canhB) * 2;
	}
}
