using System;
using static System.Console;

namespace DelegateEvent
{
	// Publisher
	class UserInput
	{
		public event SuKienNhapSo suKienNhapSo;

		public void Input()
		{
			do
			{
				Write("Nhap vao so nguyen: ");
				string s = ReadLine();
				int i = Int32.Parse(s);

				// Phát đi sự kiện
				suKienNhapSo?.Invoke(i);
			} while (true);
		}
	}
}
