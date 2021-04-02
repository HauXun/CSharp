using System;
using static System.Console;

namespace Exercise_2
{
	class Student
	{
		string id;
		string firstName;
		string email;
		int age;

		public Student(string id, string firstName, string email, int age)
		{
			this.id = id;
			this.firstName = firstName;
			this.email = email;
			if (age < 0 || age > 200)
				this.age = default;
			else
				this.age = age;
		}

		public string Id
		{
			get => id;
			set
			{
				if (value.Length > 0 && value.Length <= 20)
					id = value;
				else
					WriteLine("Ma sinh vien khong hop le!");
			}
		}

		public int Age
		{
			get => age;
			set
			{
				if (value < 0 && value > 200)
					WriteLine("Tuoi sinh vien khong hop le!");
				else
					age = value;
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Student s1 = new Student("212844A", "Khang", "khangcute@xmail.com", 20);
			WriteLine("Tuoi ban dau: " + s1.Age);
			WriteLine("Tuoi sau do: " + ++s1.Age);
			WriteLine("Ma sinh vien: " + s1.Id);
		}
	}
}
