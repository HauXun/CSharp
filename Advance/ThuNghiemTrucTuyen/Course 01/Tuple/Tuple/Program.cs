using System;
using static System.Console;

namespace Tuples
{
	class Program
	{
		static void Main(string[] args)
		{

			var MyTuple = Tuple.Create<int, string>(1, "Tran Dan");

			var MyTuple2 = new Tuple<int, string, bool>(2, "Hai Zu", true);

			WriteLine(" ID: {0}, Name: {1}", MyTuple.Item1, MyTuple.Item2);


			/*
			Dùng var để C# tự nhận diện kiểu dữ liệu
			Có thể khai báo tường minh kiểu dữ liệu là Tuple<int, int, int>
			 */
			var now = GetCurrentDayMonthYear();
			WriteLine(" Day: {0}, Month: {1}, Year: {2}", now.Item1, now.Item2, now.Item3);
			WriteLine(now.ToString());
		}

		/// <summary>
		/// Phương thức trả về 1 Tuple có 3 thuộc tính (cả 3 đều có kiểu dữ liệu là int)
		/// </summary>
		/// <returns></returns>
		static Tuple<int, int, int> GetCurrentDayMonthYear()
		{
			// Lấy ngày giờ hiện tại của hệ thống
			DateTime now = DateTime.Now;

			// Sử dụng Constructor của Tuple<> để trả về hoặc có thể sử dụng phương thức Creat
			return new Tuple<int, int, int>(now.Day, now.Month, now.Year);
		}
	}
}
