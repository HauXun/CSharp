using System;
using static System.Console;

namespace Bai04
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee e = new Employee(1, "Thuy", "Vy", 1000);
			WriteLine("ID: " + e.getID());
			WriteLine("Name: " + e.getFullName());
			WriteLine("Salary: " + e.getSalary());

			WriteLine("\n");

			e.setID(2);
			e.setFirstName("Hoai");
			e.setLastName("Ngoc");
			e.setSalary(2000);
			WriteLine("ID: " + e.getID());
			WriteLine("Name: " + e.getFullName());
			WriteLine("Salary: " + e.getSalary());
		}
	}

	class Employee
	{
		int id;
		string firstName;
		string lastName;
		int salary;

		public Employee(int id, string firstName, string lastName, int salary)
		{
			this.id = id;
			this.firstName = firstName;
			this.lastName = lastName;
			this.salary = salary;
		}

		public void setID(int id)
		{
			this.id = id;
		}

		public void setFirstName(string firstName)
		{
			this.firstName = firstName;
		}

		public void setLastName(string lastName)
		{
			this.lastName = lastName;
		}

		public void setSalary(int salary)
		{
			this.salary = salary;
		}

		public int getID() => id;
		public string getFirstName() => firstName;
		public string getLastName() => lastName;
		public int getSalary() => salary;

		public string getFullName() => firstName + " " + lastName;
	}
}
