using System;
using static System.Console;

namespace Bai03
{
	class Program
	{
		static void Main(string[] args)
		{
			Student s = new Student(1001, "Trung", 24, "Ha Noi", 5);
			WriteLine("ID: " + s.getID());
			WriteLine("Name: " + s.getName());
			WriteLine("Age: " + s.getAge());
			WriteLine("Address: " + s.getAddress());
			WriteLine("Score: " + s.getScore());

			WriteLine("\n");

			s.setScore(-7);
			WriteLine("Score: " + s.getScore());
			s.setScore(15);
			WriteLine("Score: " + s.getScore());
		}
	}

	class Student
	{
		int id;
		string name;
		int age;
		string address;
		int score;

		public Student()
		{

		}

		public Student(int id, string name, int age, string address, int score)
		{
			this.id = id;
			this.name = name;
			this.age = age;
			this.address = address;
			this.setScore(score);
		}

		public void setID(int id)
		{
			this.id = id;
		}

		public void setName(string name)
		{
			this.name = name;
		}

		public void setAge(int age)
		{
			this.age = age;
		}

		public void setAddress(string address)
		{
			this.address = address;
		}

		public void setScore(int score)
		{
			if (score < 0)
				this.score = 0;
			else if (score > 10)
				this.score = 10;
			else
				this.score = score;
		}


		public int getID() => id;
		public string getName() => name;
		public int getAge() => age;
		public string getAddress() => address;
		public int getScore() => score;
	}
}
