using System;
using static System.Console;

namespace Exercise_9
{
	class HinhTG : Hinh
	{
		// Thuộc tính
		double canhA;
		double canhB;
		double canhC;

		// Phương thức
		public HinhTG()
		{
			canhA = 0;
			canhB = 0;
			canhC = 0;
		}

		public HinhTG(double canhA, double canhB, double canhC)
		{
			this.canhA = canhA;
			this.canhB = canhB;
			this.canhC = canhC;
		}

		// Hàm nhập
		public override void Nhap()
		{
			do
			{
				Write("Nhap canh 1: ");
				canhA = double.Parse(ReadLine());
				Write("Nhap canh 2: ");
				canhB = double.Parse(ReadLine());
				Write("Nhap canh 3: ");
				canhC = double.Parse(ReadLine());

				// Kiểm tra tính chất
				if ((canhA + canhB <= canhC) || (canhA + canhC <= canhB) || (canhB + canhC <= canhA))
					WriteLine("Khong thoa man dieu kien lap tam giac. Hay nhap lai");
			} while ((canhA + canhB <= canhC) || (canhA + canhC <= canhB) || (canhB + canhC <= canhA));
		}

		// Hàm tính diện tích
		public override double TinhDT()
		{
			double p = (canhA + canhB + canhC) / 2;
			return Math.Sqrt(p * (p - canhA) * (p - canhB) * (p - canhC));
		}

		// Hàm tính chu vi
		public override double TinhCV() => canhA + canhB + canhC;
	}
}
