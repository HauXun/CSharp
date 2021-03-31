using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
	class Student
	{
		private string name;
		private int age;
		private string gender;
		private double gpa;


		public Student(string Name, int Age, string Gender, double Gpa)
		{
			name = Name;
			age = Age;
			gender = Gender;
			gpa = Gpa;
		}

		//public void getInformation()
		//{

		//}

		public void Display()
		{
			Console.WriteLine("Name: " + name);
			Console.WriteLine("Age: " + age);
			Console.WriteLine("Gender: " + gender);
			Console.WriteLine("Gpa: " + gpa);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Student s1 = new Student("Hau", 18, "Famale", 9.0);
			s1.Display();
			Console.ReadLine();
		}
	}
}
