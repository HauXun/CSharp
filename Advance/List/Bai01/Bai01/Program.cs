using System;
using static System.Console;
using System.Collections.Generic;

namespace Bai01
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>();
			int i = 0;

			// Nhập vào danh sách
			do
			{
				WriteLine("\nPhan tu thu {0}: ", i++);
				int a = int.Parse(ReadLine());
				list.Add(a);
				Write("\nNhap nua khong (y/N) >> ");
				string sl = ReadLine().ToLower();
				if (sl.Equals("n"))
					break;
			} while (true);

			// Hiển thị
			WriteLine("\nDanh sach vua nhap la >> ");
			list.ForEach(item => Write(item + "\t"));

			// Chuyển danh sách sang mảng
			int[] b = list.ToArray();

			// Sắp xếp danh sách
			list.Sort();

			// Sắp xếp trên mảng 1 chiều
			for (int j = 0; j < b.Length - 1; j++)
			{
				for (int k = i + 1; k < b.Length; k++)
				{
					int temp = b[j];
					b[j] = b[k];
					b[k] = temp;
				}
			}
		}
	}
}
