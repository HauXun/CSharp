using System;
using static System.Console;

namespace Exercise_9
{
	class Program
	{
		static void Main(string[] args)
		{
			int choice;
			Hinh h;

			Write("Nhap tuy chon tuong ung (1-HinhCN; 2-HinhTG): ");
			choice = int.Parse(ReadLine());
			switch (choice)
			{
				case 1:
					h = new HinhCN();
					h.Nhap();
					WriteLine("Dien tich HCN la: " + h.TinhDT());
					break;
				case 2:
					h = new HinhTG();
					h.Nhap();
					WriteLine("Dien tich HTG la: " + h.TinhDT());
					break;
				default:
					break;
			}
		}
	}
}
