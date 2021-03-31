using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
	class Student
	{
		private string name;
		private int age;

		public Student(string Name, int Age)
		{
			name = Name;
			age = Age;
		}
		public void Display()
		{
			Console.WriteLine("Name: {0}", name);
			Console.WriteLine("Age: {0}", age);
		}
		
	}
	class Program
	{
		static void Main(string[] args)
		{
			Student s1 = new Student("Hau", 18);
			Student s2 = new Student("Phu", 19);
			s1.Display();
			s2.Display();
			Console.ReadLine();
		}
	}
}
