using System;

namespace Bai01
{

	/// <summary>
	/// Lớp quản lý yêu cầu của người dùng tới chương trình
	/// </summary>
	class AppController
	{
		// Quản lý bài hát
		SongManager songMN = new SongManager();

		private enum SMS
		{
			DK,
			TK,
			BH
		};

		private string userCommand;
		public string UserCommand { get => userCommand; set => userCommand = value; }

		/// <summary>
		/// Get command from user
		/// </summary>
		/// <param name="command"></param>
		public void GetCommand(string command)
		{
			UserCommand = command;
		}

		public string SentCommand()
		{
			// Lấy ra từ đầu tiên để biết thao tác gì
			string[] temp = new string[2];

			if (UserCommand.Contains(' '))
			{
				temp[0] = UserCommand;
				temp[1] = "";
			}
			else
			{
				temp[0] = UserCommand.Substring(0, UserCommand.IndexOf(' '));
				temp[1] = UserCommand.Substring(UserCommand.IndexOf(' ') + 1);
			}

			string cmd = temp[0].ToUpper();

			if (cmd.Equals(SMS.BH.ToString()))
			{
				if (temp[1] != null)
				{
					return BH(temp[1].ToUpper());
				}
			}
			else if (cmd.Equals(SMS.DK.ToString()))
			{
				if (temp[1] != null)
				{
					return DK(temp[1].ToUpper());
				}
			}
			else if (cmd.Equals(SMS.TK.ToString()))
			{
				if (temp[1] != null)
				{
					return TK(temp[1].ToUpper());
				}
			}
			return WrongCommand();
		}

		/// <summary>
		/// Thực hiện lệnh đăng ký
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		private string DK(string command)
		{
			if (command.ToUpper().Equals("VIP"))
			{
				return "Ban da dang ky goi VIP Imuzik thanh cong.";
			}
			else if (command.ToUpper().Equals("IMUZIK"))
			{
				return "Ban da dang ky goi Imuzik thanh cong.";
			}
			return "Sai cu phap";
		}

		/// <summary>
		/// Thực hiện tìm kiếm nhạc
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		private string TK(string command)
		{
			if (command.Equals("ALL"))
			{
				return songMN.ShowListSong();
			}
			else
			{
				Song newSong = songMN.GetSong(command);
				if (newSong != null)
				{
					return songMN.ShowSong(newSong);
				}
			}
			return "Ten bai hat khong ton tai";
		}

		/// <summary>
		/// Thực hiện lệnh mua bài hát
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		private string BH(string command)
		{
			Song newSong = songMN.GetSong(command);
			if (newSong != null)
			{
				return "Bai hat " + newSong.Name + " da duoc dang ky.";
			}
			return "Ma bai hat khong ton tai";
		}

		string WrongCommand()
		{
			return "Sai cu phap, vui long thu lai!";
		}
	}
}
