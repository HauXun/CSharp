using System;
using System.Collections.Generic;
using static System.Console;

namespace LinkedLists
{
	class Program
	{
		static void Main(string[] args)
		{
			LinkedList<string> cacbaihoc = new LinkedList<string>();

			var bh1 = cacbaihoc.AddFirst("Bai hoc 1");
			var bh3 = cacbaihoc.AddLast("Bai hoc 3");
			LinkedListNode<string> bh2 = cacbaihoc.AddAfter(bh1, "Bai hoc 2");
			var bh4 = cacbaihoc.AddLast("Bai hoc 4");
			var bh5 = cacbaihoc.AddLast("Bai hoc 5");

			foreach (var node in cacbaihoc)
			{
				WriteLine(node);
			}

			var data = bh2;
			WriteLine(data.Value);

			data = data.Next;
			WriteLine(data.Value);
			data = data.Previous;
			WriteLine(data.Value);

			var lastNode = cacbaihoc.Last;
			while (lastNode != null)
			{
				WriteLine(lastNode.Value);
				lastNode = lastNode.Previous;
			}
		}
	}
}