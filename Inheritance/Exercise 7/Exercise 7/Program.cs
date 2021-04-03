using System;
using static System.Console;

namespace Exercise_7
{
	class Program
	{
		static void Main(string[] args)
		{
			SinhVien sv = new SinhVien("Ngoc", "Ha Noi", "12421", 7.8);
			WriteLine(sv.ToString());
		}
	}
}
