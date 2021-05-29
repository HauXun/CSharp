using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace Queues
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue<string> hoso = new Queue<string>();

			hoso.Enqueue("Ho so 1");
			hoso.Enqueue("Ho so 2");
			hoso.Enqueue("Ho so 3");

			foreach (var item in hoso)
			{
				WriteLine(item);
			}

			var hs = hoso.Dequeue();
			WriteLine($"Xu ly ho so: {hs} - {hoso.Count}");

			hs = hoso.Dequeue();
			WriteLine($"Xu ly ho so: {hs} - {hoso.Count}");

			hs = hoso.Dequeue();
			WriteLine($"Xu ly ho so: {hs} - {hoso.Count}");

		}
	}
}
