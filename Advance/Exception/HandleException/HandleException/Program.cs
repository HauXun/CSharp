using System;
using static System.Console;

namespace HandleException
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1 = 0;
			int num2 = 0;
			int divNum;
			try
			{
				WriteLine("Please enter first number >> ");
				num1 = int.Parse(ReadLine());
			}
			catch (FormatException fe)
			{
				WriteLine(fe.Message);
				WriteLine(fe.Source);
				WriteLine("Invalid format");
			}
			catch(Exception e)
			{
				WriteLine("Has an error. Please try again!");
			}
			finally
			{
				WriteLine("Finally");
			}

			try
			{
				WriteLine("Please enter second number >> ");
				num2 = int.Parse(ReadLine());
			}
			catch (FormatException fe)
			{
				WriteLine(fe.Message);
				WriteLine(fe.Source);
				WriteLine("Invalid format");
			}
			catch (Exception e)
			{
				WriteLine("Has an error. Please try again!");
			}

			try
			{
				divNum = num1 / num2;
				WriteLine("Result of num1 / num2 = {0}", divNum);
			}
			catch(DivideByZeroException dbe)
			{
				WriteLine(dbe.Message);
				WriteLine(dbe.Source);
			}
			catch (Exception e)
			{
				WriteLine("Has an error. Please try again!");
			}
		}
	}
}
