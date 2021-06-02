using System;
using static System.Console;

namespace ControlSignal
{
	class GameController
	{
		private readonly Point diemPoint = new Point(2, 2);
		private int diem = 0;

		public void Game()
		{
			Point point = new Point(10, 10);
			Point minPoint = new Point(5, 5);
			Point maxPoint = new Point(100, 30);

			Random random = new Random();

			int minPointCoin = random.Next(minPoint.X + 2, maxPoint.X - 2);
			int maxpointCoin = random.Next(minPoint.Y + 2, maxPoint.Y - 2);
			Point cointPoint = new Point(minPointCoin, maxpointCoin);

			Map map = new Map(minPoint, maxPoint);
			map.DrawMap();

			Block block = new Block(minPoint, maxPoint);
			block.Ve(point);

			Coin coin = new Coin(minPoint, maxPoint);

			Diem();

			int timer = 1;
			coin.IsGotten = true;


			while (true)
			{
				//Thread.Sleep(100 / 25);
				if (KeyAvailable)       // Nếu người dùng nhấn phím
				{
					ConsoleKeyInfo key = ReadKey();
					block.Moverment(key.Key);
				}

				if (isTrigger(block, coin) && !coin.IsGotten)
				{
					Point newPoint = new Point(block.CurrentPoint);
					block.Ve(newPoint);
					coin.IsGotten = true;
					minPointCoin = random.Next(minPoint.X + 2, maxPoint.X - 2);
					maxpointCoin = random.Next(minPoint.Y + 2, maxPoint.Y - 2);
					cointPoint = new Point(minPointCoin, maxpointCoin);
					coin.VeCoin(cointPoint);
					diem++;
					Diem();
					Write("\a");
				}

				if (timer % 2000 == 0 && coin.IsGotten)
				{
					coin.VeCoin(cointPoint);
					coin.IsGotten = false;
				}
				timer++;

				// Tránh tràn số
				if (timer >= int.MaxValue - 1000)
				{
					timer = 1;
				}

				if (timer % coin.CoinSpeed == 0)
					coin.Moverment();
			}
		}

		private void Diem()
		{
			SetCursorPosition(diemPoint.X, diemPoint.Y);
			Write("Diem: {0, 5}", diem);
			Cursor.ReturnCursor(new Point(0, 0));
		}

		private bool isTrigger(Block block, Coin coin)
		{
			if (block != null && coin != null && coin.CurrentPoint != null)
			{
				Point cointPoint = coin.CurrentPoint;
				Point birdPoint = block.CurrentPoint;
				if (cointPoint.X >= birdPoint.X
					&& cointPoint.X < birdPoint.X + block.BirdWeidth
					&& cointPoint.Y >= birdPoint.Y
					&& cointPoint.Y < birdPoint.Y + block.BirdHeight)
				{
					return true;
				}
			}
			return false;
		}
	}
}