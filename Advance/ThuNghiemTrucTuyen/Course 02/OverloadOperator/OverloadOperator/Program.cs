using System;

namespace OverloadOperator
{
	class Program
	{
		static void Main(string[] args)
		{
			Vector vector1 = new Vector(2, 3);
			Vector vector2 = new Vector(1, 1);

			// ((x1, y1), (x2, y2)) => (x1 + x2, y1 + y2)
			var vector3 = vector1 + vector2;
			vector1.Info();
			vector2.Info();
			vector3.Info();

			var vector4 = vector3 + 10;
			vector4.Info();
		}
	}
}
