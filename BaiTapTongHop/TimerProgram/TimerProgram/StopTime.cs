using System;
using static System.Console;

namespace TimerProgram
{
	class StopTime
	{
		private int phut;
		private int giay;
		private bool isResume = true;

		public int Phut
		{ 
			get => phut;
			set => phut = value;
		}

		// Biết rằng giây luôn tăng lên và reset về 00 khi đạt 60
		public int Giay
		{
			get => giay;
			set
			{
				if (giay == 59)
				{
					giay = 0;
					phut++;
					return;
				}
				giay = value;
			} 
		}

		/// <summary>
		/// Giá trị mặc định khởi tạo là 00:00
		/// </summary>
		public StopTime()
		{
			Giay = 0;
			Phut = 0;
		}

		/// <summary>
		/// Set time về mặc định
		/// </summary>
		public void ResetTime()
		{
			Phut = 0;
			Giay = 0;
			isResume = true;
		}

		/// <summary>
		/// Đếm thời gian
		/// </summary>
		public void CountTime()
		{
			if (!isResume)
				return;
			Giay++;
		}

		/// <summary>
		/// Nếu resume thì pause <> resume
		/// </summary>
		public void PauseTime()
		{
			isResume = !isResume;
		}

		/// <summary>
		/// Hiển thị thời gian
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public void ShowTime(int x, int y)
		{
			SetCursorPosition(x, y);
			Write($"{Phut} phut {Giay} giay");
		}
	}
}