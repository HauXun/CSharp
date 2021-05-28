using System;

namespace Dynamic
{
	class Student
	{
		public string Name { get; set; }
		public void Hello() => Console.WriteLine(Name);
	}
}