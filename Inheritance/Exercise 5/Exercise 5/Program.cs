using System;
using static System.Console;

namespace Exercise_5
{
	class Program
	{
		static void Main(string[] args)
		{
			ChuNhat cn1 = new ChuNhat(5, 3);
			ChuNhat cn2 = new ChuNhat(10, 7);
			Vuong v1 = new Vuong(6);
			cn1.Xuat();
			cn2.Xuat();
			v1.Xuat();
		}
	}
}
