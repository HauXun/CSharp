using System;
using System.Collections.Generic;
using static System.Console;

namespace Dictionarys
{
	class Program
	{
		static void Main(string[] args)
		{
			// Khởi tạo với 2 phần tử
			Dictionary<string, int> sodem = new Dictionary<string, int>()
			{
				["one"] = 1,
				["two"] = 2
			};

			// Thêm hoặc cập nhập
			sodem["three"] = 3;
			sodem.Add("four", 4);

			var keys = sodem.Keys;
			foreach (var k in keys)
			{
				var value = sodem[k];
				WriteLine($"{k} = {value}");
			}

			WriteLine();

			foreach (KeyValuePair<string, int> item in sodem)
			{
				WriteLine($"{item.Key} -> {item.Value}");
			}
		}
	}
}
