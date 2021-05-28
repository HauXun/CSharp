using System;
using static System.Console;

namespace OverloadOperator
{
	class Vector
	{
		private double x;
		private double y;

		public Vector(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		public void Info() => WriteLine($"x = {x}, y = {y}");

		// vector1 + vector2 => vectorResult;
		public static Vector operator +(Vector v1, Vector v2)
		{
			return new Vector(v1.x + v2.x, v1.y + v2.y);
		}

		public static Vector operator +(Vector v1, double v2)
		{
			return new Vector(v1.x + v2, v1.y + v2);
		}
	}
}
