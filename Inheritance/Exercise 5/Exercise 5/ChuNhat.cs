using System;
using static System.Console;
namespace Exercise_5
{
	class ChuNhat
	{
		// Thuộc tính
		float rong;
		float dai;

		// Phương thức khởi tạo
		public ChuNhat()
		{

		}

		public ChuNhat(float dai, float rong)
		{
			this.rong = rong;
			this.dai = dai;
		}

		// Phương thức khác
		public float getChuVi()
		{
			float cv = (this.dai + this.rong) * 2;
			return cv;
		}

		public float getDienTich()
		{
			float dt = this.dai * this.rong;
			return dt;
		}

		public void Xuat()
		{
			WriteLine("Chieu rong: " + this.rong);
			WriteLine("Chieu dai: " + this.dai);
			WriteLine("Dien tich: " + this.getDienTich());
			WriteLine("Chu vi: " + this.getChuVi());
		}
	}
}
