using System;
using static System.Console;

namespace DelegateEvent
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
			// Publisher
			UserInput userInput = new UserInput();

			userInput.suKienNhapSo += (x) => {
				WriteLine("Ban vua nhap so: " + x);
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
