using System;

namespace Dynamic
{
	class Program
	{
		// Dynamic - Kiểu dữ liệu động

		static void PrintInfo(dynamic obj)
		{
			obj.Name = "Tran Dan";
			obj.Hello();
		}

		static void Main(string[] args)
		{
			dynamic tenbien;

			tenbien = new { };

			tenbien.AbcXyz = "Son Tung";
			tenbien.CoSungDayNe();

			Student student = new Student();
			PrintInfo(student);
		}
	}
}