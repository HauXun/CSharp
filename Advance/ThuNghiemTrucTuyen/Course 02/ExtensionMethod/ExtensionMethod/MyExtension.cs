using System;

namespace MyLib
{
	public static class MyExtension
	{
		public static double BinhPhuong(this double x) => x * x;
		public static double CanBacHai(this double x) => Math.Sqrt(x);

		public static double Sin(this double x) => Math.Sin(x);
		public static double Cos(this double x) => Math.Cos(x);
	}
}
