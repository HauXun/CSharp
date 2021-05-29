using System;
using System.Text;
using static System.Console;

namespace DelegateEvent
{
	delegate void UpdateNameHandler(string name);
	class Program
	{
		static void Main(string[] args)
		{
			OutputEncoding = Encoding.Unicode;

			HocSinh hocSinh = new HocSinh();
			hocSinh.NameChanged += HocSinh_NameChanged;

			hocSinh.Name = "Trần Dần";
			WriteLine("Tên từ Class: " + hocSinh.Name);

			hocSinh.Name = "Sơn Tùng";
			WriteLine("Tên từ Class: " + hocSinh.Name);
		}

		private static void HocSinh_NameChanged(string name)
		{
			WriteLine("Tên mới: " + name);
		}
	}
}
