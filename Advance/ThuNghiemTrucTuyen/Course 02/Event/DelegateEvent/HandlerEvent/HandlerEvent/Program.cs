using System;
using static System.Console;

namespace HandlerEvent
{
	public delegate void SuKienNhapSo(int x);
	class Program
	{
		/*
		Publisher -> class -> Phát sự kiện
		Subscriber -> class -> Nhận sự kiện
		 */
		static void Main(string[] args)
		{
			CancelKeyPress += (sender, e) => {
				WriteLine();
				WriteLine("Thoat chuong trinh");
			};

			// Publisher
			UserInput userInput = new UserInput();

			userInput.suKienNhapSo += (sender, e) => {
				DuLieuNhap duLieuNhap = (DuLieuNhap)e;
				WriteLine("Ban vua nhap so: " + duLieuNhap.Data);
			};

			// Subscriber
			TinhCan tinhCan = new TinhCan();
			tinhCan.Sub(userInput);

			BinhPhuong binhPhuong = new BinhPhuong();
			binhPhuong.Sub(userInput);

			userInput.Input();
		}
	}
}
