using System;
using System.IO;
using static System.Console;

namespace StreamReadWrite
{
	class Program
	{
		static void Main(string[] args)
		{
			Write("Please enter your name: ");
			string input = ReadLine();
			using (StreamWriter sw = new StreamWriter("data.txt", append:true))
			{
				sw.WriteLine(input);
			}
			WriteLine("\nYour name was saved. Do you want to read it ? y/N:");
			string choice = ReadLine().ToUpper();
			if ("Y".Equals(choice))
			{
				string data = string.Empty;
				using (StreamReader sr = new StreamReader("data.txt"))
				{
					while ((data = sr.ReadLine()) != null)
					{
						WriteLine(data);
					}
				}
			}
		}
	}
}
