using System;
using static System.Console;

namespace DelegateEvent
{
	class BinhPhuong
	{
		public void Sub(UserInput input)
		{
			input.suKienNhapSo += TinhBinhPhuong;
		}

		public void TinhBinhPhuong(int i)
		{
			WriteLine($"Binh phuong cua {i} la {i * i}");
		}
	}
}
