using System;

namespace ControlSignal
{
	class Point
	{
		private int x;
		private int y;

		public int X { get => x; set => x = value; }
		public int Y { get => y; set => y = value; }

		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		public Point(Point point)
		{
			X = point.X;
			Y = point.Y;
		}

		public Point()
		{
			X = 0;
			Y = 0;
		}
	}
}
