using System;
using System.IO;

namespace Bai04
{
	class Program
	{
		static void Main(string[] args)
		{
			string filename = "text.txt";
			string content = "Xin chao cac ban 2020";
			//File.WriteAllText(filename, content);
			//File.AppendAllText(filename, content);
			content = File.ReadAllText(filename);
			Console.WriteLine(content);
			//File.Move("text.txt", "TranDan.txt");
			//File.Copy("text.txt", "SonTung.txt");
			File.Delete("SonTung.txt");
		}
	}
}
