using System;
using static System.Console;

namespace InitialBaseClass
{
	class Program
	{
		static void Main(string[] args)
		{
			Table table = new Table(13, 43);
			table.Display();
		}
	}
}
