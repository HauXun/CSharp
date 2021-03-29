using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
	public class Math
	{
		public static int aBs(int x)
		{
			return x < 0 ? -x : x;
		}

		public static int toTal(int x, int y)
		{
			return x + y;
		}

		public static int subTract(int x, int y)
		{
			return x - y;
		}

		public static int min(int x, int y)
		{
			return x < y ? x : y;
		}

		public static int max(int x, int y)
		{
			return x > y ? x : y;
		}

		public static int pow(int coSo, int soMu)
		{
			int Power = 1;
			for (int i = 0; i < soMu; i++)
				Power *= coSo;
			return Power;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Nhap vao x: ");
			int x = int.Parse(Console.ReadLine());
			Console.Write("Nhap vao y: ");
			int y = int.Parse(Console.ReadLine());

			Console.WriteLine(" ABS of x: " + (Math.aBs(x)));
			Console.WriteLine(" Total of x & y: " + (Math.toTal(x, y)));
			Console.WriteLine(" Subtract of x & y: " + (Math.subTract(x, y)));
			Console.WriteLine(" Min of x & y: " + (Math.min(x, y)));
			Console.WriteLine(" Max of x & y: " + (Math.max(x, y)));
			Console.WriteLine(" Power y of x: " + (Math.pow(x, y)));
			Console.Read();
		}
	}
}  