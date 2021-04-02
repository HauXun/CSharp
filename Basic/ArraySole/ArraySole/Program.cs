using System;
using static System.Console;

namespace ArraySole
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 1, 3, 4, 5, 7, 8, 9, 10, 20, 30 };
			int i = 0;
			int n = arr.Length;
			string str = "";
			int count = 0;
			while (true)
			{
				str = arr[i].ToString();
				if (count % 2 != 0 && i + 1 < n)
				{
					str += "-";
					str += arr[i + 1];
					i++;
				}
				WriteLine(str);
				i++;
				count++;
				if (i >= n)
					break;
			}
			
		}
	}
}
