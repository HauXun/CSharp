using System;
using System.Text;
using static System.Console;

namespace Hint
{
	class Program
	{
		static void Main(string[] args)
		{
			OutputEncoding = Encoding.Unicode;
			GameController game = new GameController();
			game.Game();
			ReadLine();
		}
	}
}
