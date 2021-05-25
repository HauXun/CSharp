using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai07
{
	class BankAccount
	{
		public long AccountNumber { get; }  // ReadOnly
		public string Owner { get; set; }   // Can Read, Write value
		private List<Transaction> transactions = new List<Transaction>();
		public decimal Balance    // Can only read
		{
			get
			{
				decimal balance = 0;
				foreach (var item in transactions)
				{
					balance += item.Amount;
				}
				return balance;
			}
		}

		// Gửi tiền
		public void Deposit(decimal amount, DateTime date, string note)
		{
			// Money sent to bank account
			var deposit = new Transaction(amount, date, note);
			transactions.Add(deposit);
		}

		public void Withdraw(decimal amount, DateTime date, string note)
		{
			// Withdraw money to buy something
			var withdrawal = new Transaction(-amount, date, note);
			transactions.Add(withdrawal);
		}

		private long GeneratorAccountNumbers() => ((DateTimeOffset)DateTime.Now).ToUnixTimeMilliseconds();
		public BankAccount(string owner, decimal initialBalance)
		{
			Owner = owner;
			AccountNumber = GeneratorAccountNumbers();
			//Balance = initialBalance;
			Console.WriteLine("Object initialized with \n" +
				$"Account number = {AccountNumber}\n" +
				$"Owner = {Owner}\n" +
				$"Balance = {Balance}\n");
		}
	}
}
