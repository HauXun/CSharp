using System;
using static System.Console;

namespace Delegate
{
	class Program
	{
		internal delegate void ShowLog(string message);
		static void Main(string[] args)
		{
			ShowLog log = null;
			//log = Info;

			//if (log != null)
			//	log("Xin chao");
			//log?.Invoke("Tran Dan");

			//log = Warning;
			//log("Hoc ve delegate");

			//log += Info;
			//log += Info;
			//log += Info;
			//log += Warning;
			//log += Warning;
			//log += Info;

			//log?.Invoke("Son Tung");

			// Action, Func : delegate - generic
			Action action;					// ~ delegate void Kieu()
			Action<string, int> action1;    // ~ delegate void Kieu(string s, int i);
			Action<string> action2;         // ~ delegate void Kieu(string)

			action2 = Warning;
			action2 += Info;
			action2?.Invoke("Thong bao tu Action");

			Func<int> func;							// ~ delegate int Kieu()
			Func<string, double, string> func1;     // ~ delegate string Kieu(string s, double d)

			Func<int, int, int> tinhToan;           // ~ delegate int Kieu(int a, int b)
			int a = 5;
			int b = 10;

			tinhToan = new Func<int, int, int>(Tong);
			WriteLine($"Tong la {tinhToan(a, b)}");

			tinhToan = new Func<int, int, int>(Hieu);
			WriteLine($"Hieu la {tinhToan(a, b)}");

			Tong(a, b, Warning);
		}

		static void Tong(int a, int b, ShowLog log)
		{
			int result = a + b;
			log?.Invoke($"Tong la {result}");
		}
		static int Tong(int a, int b) => a + b;
		static int Hieu(int a, int b) => a - b;

		static void Info(string s)
		{
			ForegroundColor = ConsoleColor.Green;
			WriteLine(s);
			ResetColor();
		}

		static void Warning(string s)
		{
			ForegroundColor = ConsoleColor.Red;
			WriteLine(s);
			ResetColor();
		}
	}
}
