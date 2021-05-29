using System;
using System.Collections.Generic;
using static System.Console;

namespace HashSets
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<int> set1 = new HashSet<int>() { 1, 7, 3, 9, 2, 5 };
			HashSet<int> set2 = new HashSet<int>() { 6, 3, 9, 1, 0, 4 };

			set1.Add(11);
			set1.Remove(7);

			WriteLine("Hop 2 tap hop");
			set1.UnionWith(set2);
			foreach (var item in set1)
			{
				Write(item + " ");
			}

			WriteLine("\nGiao 2 tap hop");
			set1.IntersectWith(set2);
			foreach (var item in set1)
			{
				Write(item + " ");
			}
		}
	}
}
