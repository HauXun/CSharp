using System;
using System.Threading;
using static System.Console;

namespace Hint
{
	class Program
	{
		static void Main(string[] args)
		{
			Point point = new Point(10, 10);
			Point minPoint = new Point(5, 5);
			Point maxPoint = new Point(100, 24);

			Map map = new Map(minPoint, maxPoint);
			map.DrawMap();

			Bird bird = new Bird(minPoint, maxPoint);

			bird.Ve(point);

			while (true)
			{
				//Thread.Sleep(100 / 25);
				if (KeyAvailable)       // Nếu người dùng nhấn phím
				{
					ConsoleKeyInfo key = ReadKey();
					bird.Moverment(key.Key);
				}
			}

			ReadLine();
		}
	}
}
