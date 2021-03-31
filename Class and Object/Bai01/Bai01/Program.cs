using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
	class Student
	{
		public string name;
		public int age;

		public void getInformation()
		{
			name = Console.ReadLine();
			age = int.Parse(Console.ReadLine());
		}

		public void disPlay()
		{
			Console.WriteLine(name);
			Console.WriteLine(age);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Student s1 = new Student();
			s1.getInformation();
			s1.disPlay();
			Console.ReadLine();
		}
	}
}
