using System;
using static System.ConsoleKey;
using static System.Console;

namespace Hint
{
	class Bird
	{
		const int birdWeidth = 3;
		const int birdHeight = 3;

		private Point currentPoint;
		private Point minPoint;
		private Point maxPoint;

		internal Point CurrentPoint { get => currentPoint; set => currentPoint = value; }
		internal Point MinPoint { get => minPoint; set => minPoint = value; }
		internal Point MaxPoint { get => maxPoint; set => maxPoint = value; }

		public Bird(Point minPoint, Point maxPoint)
		{
			MinPoint = minPoint;
			MaxPoint = maxPoint;
		}

		public void Ve(Point point)
		{
			if (currentPoint != null)
				Xoa();
			currentPoint = new Point(point);
			SetCursorPosition(point.X, point.Y);
			Write("===");
			point.Y++;
			SetCursorPosition(point.X, point.Y);
			Write("===");
			point.Y++;
			SetCursorPosition(point.X, point.Y);
			Write("===");
			Cursor.ReturnCursor(new Point(0, 0));
		}

		public void Xoa()
		{
			Point tempPoint = new Point(currentPoint);
			SetCursorPosition(tempPoint.X, tempPoint.Y);
			Write("   ");
			tempPoint.Y++;
			SetCursorPosition(tempPoint.X, tempPoint.Y);
			Write("   ");
			tempPoint.Y++;
			SetCursorPosition(tempPoint.X, tempPoint.Y);
			Write("   ");
			Cursor.ReturnCursor(new Point(0, 0));
		}

		public void Moverment(ConsoleKey key)
		{
			Point newPoint = new Point(currentPoint);
			bool isMove = true;
			switch (key)
			{
				case LeftArrow:     // <-
					if (--newPoint.X < minPoint.X + 1)
					{
						isMove = false;
					}
					else
					{
						newPoint.X--;
					}
					break;
				case RightArrow:     // ->
					if (++newPoint.X + birdWeidth > maxPoint.X - 1)
					{
						isMove = false;
					}
					else
					{
						newPoint.X++;
					}
					break;
				case UpArrow:     // <-
					if (--newPoint.Y < minPoint.Y + 1)
					{
						isMove = false;
					}
					else
					{
						newPoint.Y--;
					}
					break;
				case DownArrow:     // <-
					if (++newPoint.Y + birdWeidth > maxPoint.Y - 1)
					{
						isMove = false;
					}
					else
					{
						newPoint.Y++;
					}
					break;
				default:
					isMove = false;
					break;
			}
			if (isMove)
				Ve(newPoint);
		}
	}
}