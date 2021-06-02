using System;
using static System.Console;

namespace ControlSignal
{
	class Map
	{
		private Point minPoint;
		private Point maxPoint;

		internal Point MinPoint { get => minPoint; set => minPoint = value; }
		internal Point MaxPoint { get => maxPoint; set => maxPoint = value; }

		public Map(Point minPoint, Point maxPoint)
		{
			MinPoint = minPoint;
			MaxPoint = maxPoint;
		}

		public void DrawMap()
		{
			for (int i = MinPoint.X; i <= MaxPoint.X; i++)
			{
				SetCursorPosition(i, MinPoint.Y);
				Write('-');
			}

			for (int i = MinPoint.X + 1; i < MaxPoint.Y; i++)
			{
				for (int j = MinPoint.X; j <= MaxPoint.X; j++)
				{
					SetCursorPosition(j, i);
					if (j == MinPoint.X || j == MaxPoint.X)
					{
						Write(':');
					}
					else
					{
						Write(' ');
					}
				}
			}

			for (int i = MinPoint.X; i <= MaxPoint.X; i++)
			{
				SetCursorPosition(i, MaxPoint.Y - 1);
				Write('-');
			}
		}
	}
}
