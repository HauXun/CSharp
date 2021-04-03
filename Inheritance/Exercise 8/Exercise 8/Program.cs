using System;
using static System.Console;

namespace Exercise_8
{
	class Program
	{
		static void Main(string[] args)
		{
			HinhCN bucTuong = new HinhCN(2, 4);
			WriteLine("Chi phi son la: " + bucTuong.TinhChiPhiSon(bucTuong.TinhDT()));
		}
	}
}
