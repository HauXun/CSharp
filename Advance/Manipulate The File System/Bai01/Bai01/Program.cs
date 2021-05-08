using System;
using System.IO;
using static System.Console;

namespace Bai01
{
	class Program
	{
		static void Main(string[] args)
		{
			var drives = DriveInfo.GetDrives();
			foreach (var driveInfo in drives)
			{
				WriteLine("Drive: {0]", driveInfo.Name);
				WriteLine("Drive type {0}", driveInfo.DriveType);
				WriteLine("Volume label: {0}", driveInfo.VolumeLabel);
				WriteLine("File system: {0}", driveInfo.DriveFormat);
				WriteLine("Available space to current user:{0, 15} bytes", driveInfo.AvailableFreeSpace);
				WriteLine("Total available space:          {0, 15} bytes", driveInfo.TotalFreeSpace);
				WriteLine("Total size of drive:            {0, 15} bytes ", driveInfo.TotalSize);
				WriteLine("".PadLeft(40, '='));
			}
		}
	}
}
