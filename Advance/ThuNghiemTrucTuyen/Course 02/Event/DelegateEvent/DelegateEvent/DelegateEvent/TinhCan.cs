using System;
using static System.Console;

namespace DelegateEvent
{
	class TinhCan
	{
		public void Sub(UserInput input)
		{
			input.suKienNhapSo += Can;
		}

		public void Can(int i)
		{
			WriteLine($"Can bac hai cua {i} la {Math.Sqrt(i)}");
		}
	}
}
