using System;
using static System.Console;

namespace ControlSignal
{
	class Coin
	{
		const string coinChar = "Ȼ";
		private int huongDuyChuyen = 0;     // 0: <-; 1: ^; 2: ->; 3: V
		private int coinSpeed;
		private bool isGotten;

		private Point currentPoint;
		private Point minPoint;
		private Point maxPoint;

		internal Point CurrentPoint { get => currentPoint; set => currentPoint = value; }
		internal Point MinPoint { get => minPoint; set => minPoint = value; }
		internal Point MaxPoint { get => maxPoint; set => maxPoint = value; }

		public bool IsGotten { get => isGotten; set => isGotten = value; }
		public int CoinSpeed { get => coinSpeed; set => coinSpeed = value; }

		public Coin(Point minPoint, Point maxPoint)
		{
			MinPoint = minPoint;
			MaxPoint = maxPoint;
			IsGotten = true;
			CoinSpeed = 1000;
		}

		public void VeCoin(Point point)
		{
			if (currentPoint != null && !IsGotten)
				XoaCoin();
			currentPoint = new Point(point);
			SetCursorPosition(point.X, point.Y);
			Write(coinChar);
			Cursor.ReturnCursor(new Point(0, 0));
		}

		private void XoaCoin()
		{
			Point point = new Point(currentPoint);
			SetCursorPosition(point.X, point.Y);
			Write(" ");
			Cursor.ReturnCursor(new Point(0, 0));
		}

		public void Moverment()
		{
			// Đổi hướng di chuyển
			Random random = new Random();

			bool isMove = random.Next(0, 5) % 5 == 0 ? true : false;

			if (isMove)
			{
				huongDuyChuyen = random.Next(0, 4);     // [0, 3]
			}

			Move();
		}

		private void Move()
		{
			if (currentPoint == null)
				return;
			Point newPoint = new Point(currentPoint);
			bool isMove = true;
			switch (huongDuyChuyen)
			{
				case 0:     // <-
					if (--newPoint.X - 1 < minPoint.X + 1)
					{
						isMove = false;
					}
					else
					{
						//newPoint.X--;
						isMove = true;
					}
					break;
				case 2:     // ^
					if (++newPoint.X > maxPoint.X - 2)
					{
						isMove = false;
					}
					else
					{
						//newPoint.X++;
						isMove = true;
					}
					break;
				case 1:     // ->
					if (--newPoint.Y - 1 < minPoint.Y)
					{
						isMove = false;
					}
					else
					{
						//newPoint.Y--;
						isMove = true;
					}
					break;
				case 3:     // V
					if (++newPoint.Y + 1 > maxPoint.Y - 1)
					{
						isMove = false;
					}
					else
					{
						//newPoint.Y++;
						isMove = true;
					}
					break;
				default:
					isMove = false;
					break;
			}
			if (isMove)
				VeCoin(newPoint);
		}
	}
}
