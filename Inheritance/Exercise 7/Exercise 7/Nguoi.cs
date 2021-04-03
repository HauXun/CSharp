using System;
using static System.Console;

namespace Exercise_7
{
	class Nguoi
	{
		// Thuộc tính
		protected string hoTen;
		protected string diaChi;

		// Phương thức
		public Nguoi()
		{

		}

		public Nguoi(string hoTen, string diaChi)
		{
			this.hoTen = hoTen;
			this.diaChi = diaChi;
		}

		// Hàm lấy ra thông tin
		public string HoTen 
		{
			get => hoTen;
			set
			{
				//this.hoTen = HoTen;
				this.hoTen = value;
			}
		}

		public string DiaChi
		{
			get => diaChi;
			set
			{
				//this.diaChi = DiaChi;
				this.diaChi = value;
			}
		}

		// Hàm hiển thị thông tin cơ bản
		public string ToString() => "Thong tin: " + hoTen + " - " + diaChi;
	}
}
