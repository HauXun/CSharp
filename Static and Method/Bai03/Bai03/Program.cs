using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
	class Math
	{
		public static int Max(int a, int b)
		{
			return a > b ? a : b;
		}
		public static int Min(int a, int b)
		{
			return a < b ? a : b;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			Console.WriteLine("Nhap vao so a: " + a);
			Console.WriteLine("Nhap vao so b: " + b);

			//Phương thức tĩnh có thể được sử dụng mà không cần khởi tạo đối tượng
			Console.WriteLine(" Max is: " + (Math.Max(a, b)));
			Console.WriteLine(" Min is: " + (Math.Min(a, b)));
			Console.ReadLine();
		}
	}
}
