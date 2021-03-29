using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
	class Student
	{
		private string name;
		private int age;
		public static int numberOfStudent = 0;

		public Student(string Name, int Age)
		{
			name = Name;
			age = Age;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Student s1 = new Student("Manh", 19);
			Student s2 = new Student("Trung", 19);

			//Có thể truy xuất tới biến stactic trực tiếp từ lớp khai báo nó bằng toán tử "."
			Student.numberOfStudent = 2;
			Student.numberOfStudent = 3;
			Console.WriteLine(Student.numberOfStudent);
			Console.ReadLine();
		}
	}
}
