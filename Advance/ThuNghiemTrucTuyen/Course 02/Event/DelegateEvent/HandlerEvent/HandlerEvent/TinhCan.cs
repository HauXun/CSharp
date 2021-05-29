using System;
using static System.Console;

namespace HandlerEvent
{
	class TinhCan
	{
		public void Sub(UserInput input)
		{
			input.suKienNhapSo += Can;
		}

		// ~ delegate void Kieu(object? sender, EventArgs args)
		public void Can(object sender , EventArgs e)
		{
			DuLieuNhap duLieuNhap = (DuLieuNhap)e;
			int i = duLieuNhap.Data;
			WriteLine($"Can bac hai cua {i} la {Math.Sqrt(i)}");
		}
	}
}
