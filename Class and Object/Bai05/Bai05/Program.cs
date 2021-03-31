using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
	class Circle
	{
		private double radius;

		public Circle(double Radius)
		{
			radius = Radius;
		}

		public double getArea()
		{
			return 3.14 * radius * radius;
		}

		public double getCircumference()
		{
			return 3.14 * 2 * radius;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Circle s1 = new Circle(5);
			Console.WriteLine(s1.getArea());
			Console.WriteLine(s1.getCircumference());
			Console.ReadLine();
		}
	}
}
