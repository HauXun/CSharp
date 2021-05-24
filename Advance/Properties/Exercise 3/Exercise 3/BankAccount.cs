using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
	class BankAccount
	{
		public long AccountNumber { get; }  // ReadOnly
		public string Owner { get; set; }   // Can Read, Write value
		public decimal Balance { get; }     // Can only read

		// Gửi tiền
		public void Deposit(decimal amount, DateTime date, string note)
		{
			// Money sent to bank account

		}

		public void Withdraw(decimal amount, DateTime date, string note)
		{
			// Withdraw money to buy something

		}

		private long GeneratorAccountNumbers() => ((DateTimeOffset)DateTime.Now).ToUnixTimeMilliseconds();
		public BankAccount(string owner, decimal initialBalance)
		{
			Owner = owner;
			AccountNumber = GeneratorAccountNumbers();
			Balance = initialBalance;
			Console.WriteLine("Object initialized with \n" +
				$"Account number = {AccountNumber}\n" +
				$"Owner = {Owner}\n" +
				$"Balance = {Balance}\n");
		}
	}
}
