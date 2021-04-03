using System;
using static System.Console;
namespace Exercise_5
{
	class Vuong : ChuNhat
	{
		float canh;
		public Vuong(float canh) : base(canh, canh)
		{
			this.canh = canh;
		}

		public new void Xuat()
		{
			WriteLine("Thong tin hinh vuong");
			base.Xuat();
		}
	}
}
