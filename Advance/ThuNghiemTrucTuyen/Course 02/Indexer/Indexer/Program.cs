using System;

namespace Indexer
{
	class Program
	{
		static void Main(string[] args)
		{
			Vector vector = new Vector();
			vector[0] = 5;
			vector[1] = 6;
			vector.Info();

			//Console.WriteLine(vector[3]);

			vector["toadox"] = 10;
			vector["toadoy"] = 20;
			vector.Info();
		}
	}
}
