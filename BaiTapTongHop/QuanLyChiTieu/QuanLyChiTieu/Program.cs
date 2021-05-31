using System;
using static System.Console;

namespace QuanLyChiTieu
{
	class Program
	{
		static void Main(string[] args)
		{
			AppQuanLyChiTieu();
		}

		static void AppQuanLyChiTieu()
		{
			ThongKe thongKe = new ThongKe(1000000);
			while (true)
			{
				Clear();
				WriteLine("=".PadRight(50, '='));
				thongKe.Menu();
				WriteLine("=".PadRight(50, '='));
				thongKe.UserCommand();
				ReadLine();
			}
		}
	}
}
