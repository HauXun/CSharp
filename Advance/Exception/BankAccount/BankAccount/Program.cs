using System;
using static System.Console;

namespace BankAccount
{
	class Program
	{
		static void Main(string[] args)
		{
			var account = new BankAccounts("Tran Dan", 1200);
			WriteLine("Account has been created");
			account.Deposit(300, DateTime.Now, "Receive this month's salary");
			account.Withdraw(100, DateTime.Now, "Bye a keyboard");
			account.Withdraw(120, DateTime.Now, "Buy a mouse");
			//account.Deposit(-300, DateTime.Now, "Receive a fail");
			account.Withdraw(1500, DateTime.Now, "Buy a laptop");
			WriteLine("Finish transactions");
		}
	}
}
