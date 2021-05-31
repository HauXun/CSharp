using System;

namespace QuanLyChiTieu
{
	class ThongTinChiTieu
	{
		private string mucChiTieu;
		private float soTienDaChi;
		private string lyDo;

		public string MucChiTieu { get => mucChiTieu; set => mucChiTieu = value; }
		public float SoTienDaChi { get => soTienDaChi; set => soTienDaChi = value; }
		public string LyDo { get => lyDo; set => lyDo = value; }
		public ThongTinChiTieu(string mucChi, float tien, string lyDo)
		{
			MucChiTieu = mucChi;
			SoTienDaChi = tien;
			LyDo = lyDo;
		}
	}
}
