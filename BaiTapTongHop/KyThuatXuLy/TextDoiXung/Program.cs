using System;
using static System.Console;

namespace TextDoiXung
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = "   Viet  Nam Cong   San   Muon      Nam  ";
			ChuoiDoiXung(text);
			ReadLine();
		}

		static void ChuoiDoiXung(string s)
		{
			WriteLine("Chuoi ban dau: ");
			WriteLine(s);

			int x, y, i;
			x = CursorLeft;
			y = CursorTop;

			i = y;

			foreach (char item in s)
			{
				SetCursorPosition(x, i);
				Write(item);
				if (item.Equals(' '))
				{
					i = y;
				}
				else
				{
					i++;
				}
				x++;
			}
		}
	}
}
