using System;
using static System.Console;

namespace Bai07
{
	class Program
	{
		static void Main(string[] args)
		{
			Point a = new Point(1.5, 6.7);
			Point b = new Point(2.8, 3.2);
			WriteLine("The distance between point A and point B is {0}", a.distance(b));
			WriteLine("The distance between point A and point B is {0}", a.distance(2.34, 7.8));
		}
	}

	class Point
	{
		double x;
		double y;

		public Point()
		{

		}

		public Point(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		public void setX(double x)
		{
			this.x = x;
		}

		public void setY(double y)
		{
			this.y = y;
		}

		public void setXY(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		public double getX() => x;
		public double getY() => y;

		public double distance(double x, double y) => Math.Sqrt(Math.Pow((this.x - x), 2) + Math.Pow((this.y - y), 2));
		public double distance(Point b) => distance(b.getX(), b.getY()); 
	}
}
