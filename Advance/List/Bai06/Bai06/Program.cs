using System;
using System.Collections.Generic;
using static System.Console;

namespace Bai06
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedList<string, Product> product = new SortedList<string, Product>();
			product["sp1"] = new Product() { Name = "Iphone", Price = 1000, Origin = "China" };
			product["sp2"] = new Product() { Name = "Samsung", Price = 900, Origin = "China" };
			product.Add("sp3", new Product() { Name = "Nokia", Price = 1100, Origin = "China" });

			var p = product["sp2"];
			WriteLine(p.Name);

			var keys = product.Keys;
			var value = product.Values;

			foreach (var item in keys)
			{
				var products = product[item];
				WriteLine(products.Name);
			}

			foreach (KeyValuePair<string, Product> item in product)
			{
				var key = item.Key;
				var val = item.Value;
				WriteLine($"{key} - {val.Name}");
			}

			product.Remove("sp2");
			product.RemoveAt(0);
			product.Clear();
		}
	}
}