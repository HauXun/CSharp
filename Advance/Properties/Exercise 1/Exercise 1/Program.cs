using System;
using static System.Console;

namespace Exercise_1
{
	class Student
	{
		public string hoTen;
		public int namSinh;

		public void Ouput()
		{
			WriteLine("Sinh vien: {0}", hoTen);
			WriteLine("Sinh nam: {0}", namSinh);
		}
	}

	class StudentProperties
	{
		string _hoTen;
		int _namSinh;

		public string HoTen
		{
			get
			{
				return _hoTen;
			}
			set
			{
				//_hoTen = HoTen;
				_hoTen = value;
			}
		}

		public int NamSinh
		{
			get
			{
				return _namSinh;
			}
			set
			{
				if (NamSinh > 1990 && NamSinh < 2015)
					_namSinh = value;
				else
					throw new FormatException("Invalid Nam Sinh !");
			}
		}

		public void Ouput()
		{
			WriteLine("Sinh vien: {0}", _hoTen);
			WriteLine("Sinh nam: {0}", _namSinh);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Student s1 = new Student();
			s1.hoTen = "Tran Hoai Ngoc";
			s1.namSinh = 1998;
			s1.Ouput();

			WriteLine("\n");
			StudentProperties s2 = new StudentProperties();
			s2.HoTen = "Hieu PC";
			s2.NamSinh = 1987;
			s2.Ouput();
		}
	}
}
