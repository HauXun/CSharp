using System;
using static System.Console;

namespace Bai01
{
	class Program
	{
		static void Main(string[] args)
		{
			Contact contact = new Contact();
			contact.address = "Phao son pa lay";
			contact.creditCard = 2011379;
			contact.gender = true;
			contact.birthday = DateTime.Parse("30/04/1975", new System.Globalization.CultureInfo("pt-BR"));
			contact.Print();
			ReadKey();
		}
	}
	public struct Contact
	{
		public string address;
		public int creditCard;
		public bool gender;
		public DateTime birthday;
		public void Print()
		{
			WriteLine("Address: " + address);
			WriteLine("CreditCard: " + creditCard);
			WriteLine("Gender: " + (gender ? "Male" : "Famale"));
			WriteLine("Birthday: " + birthday.ToString("dd/MM/yyyy"));
		}
	}
}
