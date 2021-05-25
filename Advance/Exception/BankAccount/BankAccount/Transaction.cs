using System;

namespace BankAccount
{
	class Transaction
	{
		public decimal Amount { get; }
		public DateTime Date { get; }
		public string Note { get; set; }
		public Transaction(decimal amount, DateTime date, string note)
		{
			Amount = amount;
			Date = date;
			Note = note;

		}
	}
}
