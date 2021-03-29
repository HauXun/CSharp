using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai08
{
	class Student
	{
		private string name;
		private char gender;

		public Student()
		{
			name = "Unknow";
			gender = 'u';
		}

		public Student(string Name)
		{
			name = Name;
			gender = 'u';
		}

		public Student(char Gender)
		{
			gender = Gender;
			name = "Unknow";
		}

		public Student(string Name, char Gender)
		{
			name = Name;
			gender = Gender;
		}

		public void Display()
		{
			Console.WriteLine("Name: " + name);
			if (gender == 'm')
				Console.WriteLine("Gender: Male");
			else if (gender == 'f')
				Console.WriteLine("Gender: Female");
			else if (gender == 'u')
				Console.WriteLine("Gender: Unknow");
		}
		class Program
		{
			static void Main(string[] args)
			{
				Console.Write("Nhap vao ten: ");
				string name = Console.ReadLine();
				char gender;
				Console.Write("Nhap vao gioi tinh: ");
				gender = char.Parse(Console.ReadLine());

				Console.WriteLine(" S1 empty: ");
				Student s1 = new Student();
				s1.Display();
				Console.WriteLine(" S2 just name: ");
				Student s2 = new Student(name);
				s2.Display();
				Console.WriteLine(" S3 just gender: ");
				Student s3 = new Student(gender);
				s3.Display();
				Console.WriteLine(" S4 is embrace: ");
				Student s4 = new Student(name, gender);
				s4.Display();
				Console.ReadLine();
			}
		}
	}
}