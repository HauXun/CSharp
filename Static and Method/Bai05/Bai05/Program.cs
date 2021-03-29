using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
	class Math
	{
		public static int max(int a, int b)
		{
			return a > b ? a : b;
		}

		public static int max(int a, int b, int c)
		{
			//return a > b ? (a > c ? a : c) : (b > c ? b : c);
			return max(max(a, b), c);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
		//	Console.Write("Nhap vao x: ");
		//	int x = int.Parse(Console.ReadLine());
			Console.WriteLine(Math.max(2, 4));
			Console.WriteLine(Math.max(2, 4, 6));
			Console.Read();
		}
	}
}
