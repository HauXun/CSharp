using System;
using System.IO;
using static System.Console;

namespace Bai02
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = "ABC";

			// Directory.CreateDirectory(path);
			// Directory.Delete(path);

			if (Directory.Exists(path))
				WriteLine($"{path} - ton tai");
			else
				WriteLine($"{path} - khong ton tai");

			var directories = Directory.GetDirectories("E:\\Document\\VisualStudio\\VisualStudio2013\\Project\\TuHocCSharp\\Advance\\Manipulate The File System\\Bai02\\Bai02\\obj");
			foreach (var directorie in directories)
			{
				WriteLine(directorie);
			}
			WriteLine("".PadRight(20, '='));
			var files = Directory.GetFiles("E:\\Document\\VisualStudio\\VisualStudio2013\\Project\\TuHocCSharp\\Advance\\Manipulate The File System\\Bai02\\Bai02\\obj");
			foreach (var file in files)
			{
				WriteLine(file);
			}
			WriteLine("".PadRight(20, '='));
			ListFileDirectory("E:\\Document\\VisualStudio\\VisualStudio2013\\Project\\TuHocCSharp\\Advance\\Manipulate The File System\\Bai02\\Bai02\\obj");
		}
		static void ListFileDirectory(string path)
		{
			String[] directories = Directory.GetDirectories(path);
			String[] files = Directory.GetFiles(path);
			foreach (var file in files)
			{
				WriteLine(file);
			}
			foreach (var directory in directories)
			{
				WriteLine(directory);
				ListFileDirectory(directory);
			}
		}
	}
}
