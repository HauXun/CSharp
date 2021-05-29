using System;
using System.IO;
using static System.Console;

namespace Exceptions
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 5;
			int b = 0;

			// Exception
			try
			{
				var c = a / b;      // Phát sinh đối tượng lớp Exception, Kế thừa Exception
				WriteLine(c);
				int[] i = { 1, 2 };
				var x = i[5];
			}
			catch (DivideByZeroException dbe)
			{
				WriteLine(dbe.Message);
				WriteLine(dbe.StackTrace);
				WriteLine(dbe.GetType().Name);
				WriteLine("Phep chia co loi");
			}
			catch (IndexOutOfRangeException ie)
			{
				WriteLine(ie.Message);
				WriteLine("Chi so mang khong phu hop");
			}
			catch (Exception e)
			{
				WriteLine(e.Message);
				WriteLine(e.StackTrace);
				WriteLine(e.GetType().Name);
			}
			WriteLine("Ket thuc");

			// ============================================================================

			string path = "";
			try
			{
				string s = File.ReadAllText(path);
				WriteLine(s);
			}
			catch (FileNotFoundException fnfe)
			{
				WriteLine(fnfe.Message);
				WriteLine("File khong ton tai");
			}
			catch (ArgumentException ane)
			{
				WriteLine(ane.Message);
				WriteLine("Duong dan file phai khac null");
			}
			catch (Exception e)
			{
				WriteLine(e.Message);
				WriteLine(e.GetType().Name);
			}

			// ============================================================================

			try
			{
				Register("Tran Dan", 64);
			}
			catch (NameEmptyException nee)
			{
				WriteLine(nee.Message);
			}
			catch (AgeException ae)
			{
				WriteLine(ae.Message);
				ae.Details();
			}

		}

		static void Register(string name, int age)
		{
			if (string.IsNullOrEmpty(name))
			{
				//Exception exception = new Exception("Ten phai khac rong");
				//throw exception;
				throw new NameEmptyException();
			}
			if (age < 18 || age > 100)
			{
				//throw new Exception("Tuoi khong phu hop");
				throw new AgeException(age);
			}
			WriteLine($"Xin chao {name} ({age})");
		}
	}
}
