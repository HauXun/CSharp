using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;

namespace Bai02
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
			List<string> list = new List<string>(5);
			List<string> list2 = new List<string>(5);

			WriteLine("\nNhap ten cac quoc gia va thu do tuong ung:");
			for (int i = 0; i < 5; i++)
			{
				Write("Nhap ten quoc gia thu {0} >> ", i + 1);
				string tenQG = ReadLine();
				list.Add(tenQG);

				Write("\tNhap ten thanh pho >> ");
				list2.Add(ReadLine());
			}

			// Đổ list và list 2 vào dictionary
			for (int i = 0; i < 5; i++)
			{
				keyValuePairs.Add(list[i], list2[i]);
			}

			// Hiển thị dictionary
			foreach (KeyValuePair<string, string> item in keyValuePairs)
			{
				WriteLine("\nQuoc gia: {0} - Thu do: {1}", item.Key, item.Value);
			}

			foreach (KeyValuePair<string, string> item in keyValuePairs)
			{
				if (item.Key.Equals("Viet Nam"))
					WriteLine("Thu do la >> " + item.Value);
			}
		}
	}
}
