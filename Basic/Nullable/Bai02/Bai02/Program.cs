using System;

namespace Bai02
{
	class ABC
	{
		public void XinChao() => Console.WriteLine("Xin chao Tran Dan");
	}
	class Program
	{
		static void Main(string[] args)
		{
			ABC a = null;
			if (a != null)
				a.XinChao();
			a?.XinChao();

			int? age = null;
			age = 10;
			if (age.HasValue || age != null)
			{
				int _age = age.Value;
				_age = (int)age;
				Console.WriteLine(_age);
			}
		}
	}
}
