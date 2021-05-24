using System;
using System.Collections.Generic;
using static System.Console;

namespace Bai05
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Product> product = new List<Product>() {
				new Product() {
					Name = "Iphone X", Price = 1000, Origin = "China", ID = 1
				},
				new Product() {
					Name = "Samsung", Price = 900, Origin = "China", ID = 2
				},
				new Product() {
					Name = "Sony", Price = 1100, Origin = "Japan", ID = 3
				},
				new Product() {
					Name = "Nokia", Price = 800, Origin = "China", ID = 4
				}
			};

			// Japan
			var p = product.Find(
				(p) =>
				{
					return p.Origin == "Japan";
				}
				);
			if (p != null)
				WriteLine($"{p.Name} - {p.Price} - {p.Origin}");
			WriteLine('\n');

			// <= 900
			var s = product.FindAll(
				(p) =>
				{
					return p.Price <= 900;
				}
				);
			foreach (var item in s)
			{
				WriteLine($"{item.Name} - {item.Price} - {item.Origin}");
			}
			WriteLine('\n');

			// S
			var x = product.FindAll(
				(p) =>
				{
					return p.Name.StartsWith('S');
				}
				);
			foreach (var item in x)
			{
				WriteLine($"{item.Name} - {item.Price} - {item.Origin}");
			}
			WriteLine('\n');

			foreach (var item in product)
			{
				WriteLine($"{item.Name} - {item.Price} - {item.Origin}");
			}
			WriteLine('\n');

			// Sort
			product.Sort(
				(p1, p2) =>
				{
					// 0 p1 == p2
					// 1 p1 > p2
					// -1 p1 < p2
					if (p1.Price == p2.Price) return 0;
					if (p1.Price > p2.Price) return 1;
					return -1;
				}
				);
			foreach (var item in product)
			{
				WriteLine($"{item.Name} - {item.Price} - {item.Origin}");
			}
			WriteLine('\n');
		}
	}
}
