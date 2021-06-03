using System;

namespace QuanLyNongTrai
{
	class Program
	{
		static void Main(string[] args)
		{
			FarmingController farmingController = new FarmingController();
			while (true)
			{
				Console.Clear();
				farmingController.Menu();
				farmingController.UserCommand();
			}
		}
	}
}