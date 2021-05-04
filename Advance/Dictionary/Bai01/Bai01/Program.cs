using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace Bai01
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
			keyValuePairs.Add(1, "One");
			keyValuePairs.Add(2, "Two");
			keyValuePairs.Add(3, "Three");

			WriteLine("\nForeach");
			foreach (KeyValuePair<int, string> item in keyValuePairs)
			{
				int key = item.Key;
				string value = item.Value;
				WriteLine("Key {0} - Value {1}", key, value);
			}

			WriteLine("\nArray");
			for (int i = 0; i < keyValuePairs.Count; i++)
			{
				int key = keyValuePairs.Keys.ElementAt(i);
				string value = keyValuePairs[key];
				WriteLine("Key {0} - Value {1}", key, value);
			}

			ReadKey();
		}
	}
}
