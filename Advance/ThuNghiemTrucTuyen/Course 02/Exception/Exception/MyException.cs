using System;

namespace Exceptions
{
	class NameEmptyException : Exception
	{
		public NameEmptyException() : base("Ten phai khac rong") { }
	}

	class AgeException : Exception
	{
		public int Age { get; set; }
		public AgeException(int age) : base("Tuoi khong phu hop") { Age = age; }

		public void Details() => Console.WriteLine($"Tuoi {Age} khong phu hop");
	}
}
