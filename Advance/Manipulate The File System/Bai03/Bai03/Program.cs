using System;
using System.IO;

namespace Bai03
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Path.DirectorySeparatorChar);
			var path = Path.Combine("TranDan", "SonTung", "JackCam", "TranDucBo.exe");
			//path = Path.ChangeExtension(path, "dll");
			Console.WriteLine(path);
			Console.WriteLine(Path.GetFileName(path));
			Console.WriteLine(Path.GetExtension(path));
			Console.WriteLine(Path.GetFullPath(path));
			Console.WriteLine(Path.GetDirectoryName(path));

			path = Path.GetRandomFileName();
			Console.WriteLine(path);
			path = Path.GetTempFileName();
			Console.WriteLine(path);
		}
	}
}
