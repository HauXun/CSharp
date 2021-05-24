using System;
using static System.Console;

namespace CustomException
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLine("Please enter your age >> ");
			string input = ReadLine();

			try
			{
				byte age = byte.Parse(input);
				if (age < 18)
					throw new InvalidAgeException("You didn't enough age");
			}
			catch (FormatException fe)
			{
				WriteLine("You have to type a number");
			}
			catch(InvalidAgeException iae)
			{
				WriteLine(iae.Message);
			}
		}
	}
}
