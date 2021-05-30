using System;
using static System.Console;

namespace Bai01
{
	class Program
	{
		// Một lớp quản lý yêu cầu của người dùng
		static AppController app = new AppController();

		static void Main(string[] args)
		{
			//app.ShowListSong();
			while (true)
				UserCommand();
		}

		// Đợi xử lý của người dùng
		static void UserCommand()
		{
			string command = ReadLine();

			// Người dùng gửi yêu cầu cho hệ thống
			app.GetCommand(command);

			// Hệ thống trả về thông báo
			string systemMessage = app.SentCommand();

			// Xuất ra thông báo
			WriteLine(systemMessage);
		}
	}
}
