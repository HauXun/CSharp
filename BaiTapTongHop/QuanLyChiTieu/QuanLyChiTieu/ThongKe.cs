using System;
using System.Collections.Generic;
using static System.Console;

namespace QuanLyChiTieu
{
	class ThongKe
	{
		private float tongTien;
		private List<string> mucChiTieu;
		private List<ThongTinChiTieu> danhSachChi;

		public float TongTien { get => tongTien; set => tongTien = value; }
		public List<string> MucChiTieu { get => mucChiTieu; set => mucChiTieu = value; }
		internal List<ThongTinChiTieu> DanhSachChi { get => danhSachChi; set => danhSachChi = value; }

		public ThongKe(float tien)
		{
			TongTien = tien;
			DanhSachChi = new List<ThongTinChiTieu>();
			MucChiTieu = new List<string>() { "Quy den", "Di cho", "Mua sam", "Others" };
		}

		/// <summary>
		/// Xem số tiền còn lại trong tài khoản
		/// </summary>
		public void XemSoTienTrongTaiKhoan()
		{
			WriteLine($"Tai khoan cua quy khach con {TongTien} vnd");
		}

		/// <summary>
		/// Xem thông tin các khoản đã chi
		/// </summary>
		/// <param name="mucChiTieu"></param>
		public void KhoanDaChi(string mucChiTieu = null)
		{
			WriteLine("Chi cho {0}: ", mucChiTieu ?? "");
			foreach (ThongTinChiTieu item in DanhSachChi)
			{
				if (item != null && (mucChiTieu == null || (mucChiTieu != null && item.MucChiTieu.Equals(mucChiTieu))))
				{
					WriteLine($"{item.MucChiTieu} | {item.SoTienDaChi} | {item.LyDo}");
				}
			}
		}

		/// <summary>
		/// Xử lý vấn đề chi tiền của user
		/// </summary>
		/// <param name="mucChi"></param>
		/// <param name="soTienCanChi"></param>
		/// <param name="lyDo"></param>
		public void ChiTien(string mucChi, float soTienCanChi, string lyDo = null)
		{
			if (tongTien - soTienCanChi < 0)
			{
				WriteLine("Khong the chi qua so tien con lai trong tai khoan.");
				return;
			}	
			else
			{
				ThongTinChiTieu newChi = new ThongTinChiTieu(mucChi, soTienCanChi, lyDo);
				DanhSachChi.Add(newChi);

				tongTien -= soTienCanChi;

				WriteLine($"Da chi cho viec {mucChi} voi so tien {soTienCanChi} vi ly do {lyDo}");
				XemSoTienTrongTaiKhoan();
			}	
		}

		/// <summary>
		/// Cập nhập thêm số tiền vào trong tài khoản
		/// </summary>
		public void CapNhapTienTrongTaiKhoan()
		{
			Write("Nhap so tien can them vao tai khoan >> ");
			float tien = 0;

			if (float.TryParse(ReadLine(), out tien))
			{
				TongTien += tien;
				XemSoTienTrongTaiKhoan();
			}
			else
			{
				WriteLine("So tien khong hop le");
			}	
		}

		/// <summary>
		/// Chi các khoản theo mục
		/// </summary>
		public void CacKhoanDaChiTheoMuc()
		{
			KhoanDaChi(ShowMucChiTieu());
		}

		/// <summary>
		/// Show danh sách các mục chi tiêu
		/// </summary>
		string ShowMucChiTieu()
		{
			// Xuất ra danh sách các mục chi tiêu
			WriteLine("Chon muc can chi: ");
			int j = 0;
			foreach (var item in MucChiTieu)
			{
				j++;
				WriteLine(j + ". " + item);
			}

			string command = ReadLine();
			int i = 0;
			string mucLuaChon = "";

			if (Int32.TryParse(command, out i) && i >= 0 && i < MucChiTieu.Count)
			{
				mucLuaChon = MucChiTieu[i - 1];
			}
			else
			{
				WriteLine("Muc lua chon sai");
			}
			return mucLuaChon;
		}
		
		public void ChiTienUser()
		{
			string mucChi = ShowMucChiTieu();

			Write("So tien can chi >> ");
			string tien = ReadLine();
			float soTien = 0;
			if (!Single.TryParse(tien, out soTien))
			{
				WriteLine("So tien khong hop le!");
				return;
			}	

			Write("Ly do >> ");
			string lyDo = ReadLine();

			ChiTien(mucChi, soTien, lyDo);
		}
		
		/// <summary>
		/// Show menu
		/// </summary>
		public void Menu()
		{
			string menu = "\t Phan mem quan ly chi tieu"
				+ Environment.NewLine
				+ "1. Xem tong tien"
				+ Environment.NewLine
				+ "2. Cap nhap so tien trong tai khoan"
				+ Environment.NewLine
				+ "3. Xem cac khoan da chi"
				+ Environment.NewLine
				+ "4. Xem cac khoan da chi theo muc"
				+ Environment.NewLine
				+ "5. Chi Tien";
			WriteLine(menu);
		}

		/// <summary>
		/// Get command from user
		/// </summary>
		public void UserCommand()
		{
			string command = ReadLine();

			switch (command)
			{
				case "1":
					XemSoTienTrongTaiKhoan();
					break;
				case "2":
					CapNhapTienTrongTaiKhoan();
					break;
				case "3":
					KhoanDaChi();
					break;
				case "4":
					CacKhoanDaChiTheoMuc();
					break;
				case "5":
					ChiTienUser();
					break;
				default:
					WriteLine("Vui long nhap tuy chon chuc nang tuong ung menu!");
					break;
			}
		}
	}
}
