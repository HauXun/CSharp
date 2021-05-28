using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace AnonymousType
{
	class Program
	{

		// Anonymous - Kiểu dữ liệu vô danh
		// Object - Thuộc tính - Chỉ đọc
		// new {thuoctinh = giatri, thuoctinh2 = giatri2}

		static void Main(string[] args)
		{
			var sanpham = new {
				Ten = "Iphone 8",
				Gia = 1000,
				NamSx = 2018
			};

			WriteLine(sanpham.Ten);
			WriteLine(sanpham.Gia);

			List<Sinhvien> sinhvien = new List<Sinhvien>() { 
				new Sinhvien() {HoTen = "Nam", NamSinh = 2000, NoiSinh = "Binh Duong"},
				new Sinhvien() {HoTen = "Dan", NamSinh = 2002, NoiSinh = "Nam Dinh"},
				new Sinhvien() {HoTen = "Long", NamSinh = 2001, NoiSinh = "Vinh Phuc"},
				new Sinhvien() {HoTen = "Minh", NamSinh = 2000, NoiSinh = "Kien Giang"}
			};

			var ketqua = from sv in sinhvien
						 where sv.NamSinh < 2001
						 select new {
							 Ten = sv.HoTen,
							 NS = sv.NoiSinh
						 };

			foreach (var sv in ketqua)
			{
				WriteLine(sv.Ten + " - " + sv.NS);
			}
		}
	}
}