using System;
using static System.Console;

namespace Exercise_7
{
	class SinhVien : Nguoi
	{
		string maSV;
		double diemTBC;

		public SinhVien()
		{

		}

		public SinhVien(string hoTen, string diaChi, string maSV, double diemTBC) : base (hoTen, diaChi)
		{
			this.maSV = maSV;
			this.diemTBC = diemTBC;
		}

		// Hàm hiển thị thông tin cơ bản của sinh viên
		public string ToString() => "Thong tin sinh vien: " + hoTen + " - " + diaChi + " - " + maSV + " - " + diemTBC;
	}
}
