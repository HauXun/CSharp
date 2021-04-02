using System;
using System.IO;
using static System.Console;

namespace DirectoryAndFile
{
	class Program
	{
		static void Main(string[] args)
		{
			DirectoryInfo myDir = new DirectoryInfo(@"E:\Download");
			if (myDir.Exists)
			{
				FileInfo[] files = myDir.GetFiles();
				DirectoryInfo[] dfiles = myDir.GetDirectories();
				//foreach (FileInfo file in files)
				//{
				//	WriteLine(file.FullName);
				//}
				WriteLine("\n");
				foreach (DirectoryInfo file in dfiles)
				{
					WriteLine(file.FullName);
				}
			}
			else
			{
				WriteLine("Directory is not existed");
			}
		}
	}
}
