using System;
using System.IO;
using static System.Console;

namespace FileStreamExample
{
	class Program
	{
		static void Main(string[] args)
		{
			FileStream fileStream = new FileStream(@"text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			for (int i = 1; i <= 20; i++)
			{
				fileStream.WriteByte((byte)i);
			}
			fileStream.Position = 0;
			WriteLine("Write OK");
			for (int i = 0; i <= 20; i++)
			{
				Write(fileStream.ReadByte() + "\t");
			}
			fileStream.Close();
		}
	}
}
