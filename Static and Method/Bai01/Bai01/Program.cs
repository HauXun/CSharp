using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
	class MauSac
	{
		public static string MauChuDao;

		static MauSac()
		{
			DateTime Date = DateTime.Now;
			switch(Date.DayOfWeek)
			{
				case DayOfWeek.Friday:
					MauChuDao = "Black";
					break;
				case DayOfWeek.Monday:
					MauChuDao = "Blue";
					break;
				case DayOfWeek.Saturday:
					MauChuDao = "Green";
					break;
				case DayOfWeek.Sunday:
					MauChuDao = "Yellow";
					break;
				case DayOfWeek.Thursday:
					MauChuDao = "Pink";
					break;
				case DayOfWeek.Tuesday:
					MauChuDao = "Red";
					break;
				case DayOfWeek.Wednesday:
					MauChuDao = "Purple";
					break;
			}
		}
	}
	
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Mau chu dao cua hom nay la: " + MauSac.MauChuDao);
			Console.ReadLine();
		}
	}
}
