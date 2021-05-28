using System;
using System.Linq;
using static System.Console;

namespace Lambda
{
	class Program
	{

		/*
		Lambda - Anonymous function

		1)
		(thamso) => bieuthuc;

		2)
		(thamso) =>	{
			cacbieuthuc
			return bieuthuctrave;
		}
		 */

		static void Main(string[] args)
		{
			Action<string> thongbao;
			thongbao = (string s) => WriteLine(s);      // ~ delegate void Kieu(string s) = Action

			thongbao?.Invoke("Xin chao qui zi");

			Action thongbao2;
			thongbao2 = () => WriteLine("Xin chao qui zi nha");
			thongbao2?.Invoke();

			Action<string, string> thongbao3;
			thongbao3 = (msg, name) => WriteLine($"{msg} {name}");
			thongbao3?.Invoke("Xin chao", "qui zi dong bao");

			Func<int, int, int> tinhtoan;
			tinhtoan = (a, b) => {
				int result = a + b;
				return result;
			};
			WriteLine(tinhtoan?.Invoke(5, 6));

			int[] array = { 1, 7, 3, 9, 2, 5, 7, 3, 0, 6, 4 };
			array.ToList().ForEach((x) => {
				if (x % 2 != 0)
					WriteLine(x);
			});

			var result = array.Select((int x) => Math.Sqrt(x));
			foreach (var item in result)
			{
				WriteLine($"{item}");
			}

			var result2 = array.Where(
				(x) => {
					return x % 4 == 0;
				}
				);
			result2.ToList().ForEach(x => WriteLine(x));
		}
	}
}
