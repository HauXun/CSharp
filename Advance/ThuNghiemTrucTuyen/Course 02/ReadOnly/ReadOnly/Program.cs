using System;

namespace ReadOnly
{
	class Program
	{
		static void Main(string[] args)
		{
			Student student = new Student("Tran Dan");
			Console.WriteLine(student.name);
		}
	}
}
