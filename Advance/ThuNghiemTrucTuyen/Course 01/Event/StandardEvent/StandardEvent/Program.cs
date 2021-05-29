using System;
using System.Text;
using static System.Console;

namespace StandardEvent
{
	class Program
	{
		static void Main(string[] args)
		{
			OutputEncoding = Encoding.Unicode;

			HocSinh hocSinh = new HocSinh();
			hocSinh.NameChanged += HocSinh_NameChanged;

			hocSinh.Name = "Thay đổi lần 1.";
			hocSinh.Name = "Thay đổi lần 2.";
			hocSinh.Name = "Thay đổi lần 3.";
		}

		private static void HocSinh_NameChanged(object sender, NameChangedArgs e)
		{
			WriteLine("Tên có thay đổi là " + e.Name);
		}
	}
}
