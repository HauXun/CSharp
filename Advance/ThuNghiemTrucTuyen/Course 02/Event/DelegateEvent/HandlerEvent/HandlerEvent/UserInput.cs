using System;
using static System.Console;

namespace HandlerEvent
{
	// Publisher
	class UserInput
	{
		// ~ delegate void Kieu(object? sender, EventArgs args)
		public event EventHandler suKienNhapSo;

		public void Input()
		{
			do
			{
				Write("Nhap vao so nguyen: ");
				string s = ReadLine();
				int i = Int32.Parse(s);

				// Phát đi sự kiện
				suKienNhapSo?.Invoke(this, new DuLieuNhap(i));
			} while (true);
		}
	}
}
