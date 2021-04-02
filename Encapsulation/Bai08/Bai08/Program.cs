using System;
using static System.Console;

namespace Bai08
{
	class Program
	{
		static void Main(string[] args)
		{
			Account acc = new Account(001, "Tuan", 2000);
			acc.display();
			acc.withdraw(2100);
			acc.deposit(600);
			WriteLine("Balance: " + acc.getBalance());
			acc.withdraw(2100);
			WriteLine("Balance: " + acc.getBalance());
		}
	}

	class Account
	{
		int id;
		string name;
		int balance = 0;

		public Account(int id, string name)
		{
			this.id = id;
			this.name = name;
		}

		public Account(int id, string name, int balance)
		{
			this.id = id;
			this.name = name;
			this.balance = balance;
		}

		public void setName(string name)
		{
			this.name = name;
		}

		public int getID() => id;
		public string getName() => name;
		public int getBalance() => balance;

		public void deposit(int amount)
		{
			balance += amount;
		}

		public void withdraw(int amount)
		{
			if (balance >= amount)
				balance -= amount;
			else
				WriteLine("That amount exceeds your current balance.");
		}

		public void display()
		{
			WriteLine("ID: " + id);
			WriteLine("Name: " + name);
			WriteLine("Balamce: " + balance);
		}
	}
}
