using System;
using static System.Console;	

namespace Bai01
{
	class Program
	{
		static void Main(string[] args)
		{
			Person P = new Person();
			Person p = new Person(1001, "Quynh", 24, "Ha Noi");
			P.setID(1001);
			P.setName("Quynh");
			P.setAge(24);
			P.setAddress("Ha Noi");

			WriteLine("ID: " + p.getID());
			WriteLine("Name: " + p.getName());
			WriteLine("Age: " + p.getAge());
			WriteLine("Address: " + p.getAddress());
		}
	}

	class Person
	{
		int id;
		string name;
		int age;
		string address;

		public Person()
		{

		}

		public Person(int id, string name, int age, string address)
		{
			this.id = id;
			this.name = name;
			this.age = age;
			this.address = address;
		}

		public int getID() => id;
		public void setID(int id)
		{
			this.id = id;
		}

		public string getName() => name;
		public void setName(string name)
		{
			this.name = name;
		}

		public int getAge() => age;
		public void setAge(int age)
		{
			this.age = age;
		}

		public string getAddress() => address;
		public void setAddress(string address)
		{
			this.address = address;
		}
	}
}
