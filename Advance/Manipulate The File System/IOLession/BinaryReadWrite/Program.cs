using System;
using System.IO;
using static System.Console;

namespace BinaryReadWrite
{
	class Program
	{
		static void Main(string[] args)
		{
			string strA = "ABCD";
			byte byteA = 12;
			double doubleA = 11.23;

			using (BinaryWriter bw = new BinaryWriter(new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)))
			{
				try
				{
					bw.Write(strA);
					bw.Write(doubleA);
					bw.Write(byteA);
				}
				catch (IOException ioe)
				{
					WriteLine(ioe.Message);
				}
			}

			using (BinaryReader br = new BinaryReader(new FileStream("test.txt", FileMode.Open, FileAccess.Read)))
			{
				WriteLine(br.ReadString());
				WriteLine(br.ReadDouble());
				WriteLine(br.ReadByte());
			}

			WriteLine("Save OK");
		}
	}
}
