using System;
using System.Collections.Generic;
using static System.Console;

namespace Bai04
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> ds1 = new List<int>() { 7, 8, 9, 5, 3, 8, 2, 0, 1, 3 };

			//ds1.Add();
			//ds1.Add();
			//// Thêm 1 nhóm các phần tử
			//ds1.AddRange(new int[] { 3, 4, 5 });
			//ds1.Insert();
			//ds1.RemoveAt();
			//ds1.RemoveAll();
			//ds1.Remove();
			//ds1.Clear();

			var n = ds1.Find(
				(e) =>
				{
					return e % 2 == 0;
				}
				);
			WriteLine(n);

			var ds = ds1.FindAll(x => x % 2 == 0);
			ds.ForEach(x => Write($"{x} "));
		}
	}
}
