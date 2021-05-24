using MyNamespace;
using Xyz = MyNamespace.Abc;
using System;
using static System.Console;
using static System.Math;

namespace Bai02
{
	class Program
	{
		static void Main(string[] args)
		{
			MyNS.XinChao();
			Xyz.MyNS.XinChao();
			WriteLine('\n');

			WriteLine(PI);
			WriteLine(Sin(PI / 4));
			WriteLine('\n');

			SanPham.Product product = new SanPham.Product();
			product.Name = "IPad";
			product.Price = 1000;
			product.Description = "This is IPad";
			product.manufactory = new SanPham.Product.Manufactory();
			product.manufactory.Name = "Apple";

			WriteLine(product.GetInfo());
			WriteLine('\n');
		}
	}
}
