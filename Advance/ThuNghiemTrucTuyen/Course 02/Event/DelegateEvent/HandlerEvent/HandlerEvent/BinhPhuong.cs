using System;
using static System.Console;

namespace HandlerEvent
{
	class BinhPhuong
	{
		public void Sub(UserInput input)
		{
			input.suKienNhapSo += TinhBinhPhuong;
		}

		// ~ delegate void Kieu(object? sender, EventArgs args)
		public void TinhBinhPhuong(object sender, EventArgs e)
		{
			DuLieuNhap duLieuNhap = (DuLieuNhap)e;
			int i = duLieuNhap.Data;
			WriteLine($"Binh phuong cua {i} la {i * i}");
		}
	}
}
