using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace Lists
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Khai báo và khởi tạo List

			List<int> MyList = new List<int>();     // Khởi tạo 1 List các số nguyên rỗng

			List<int> MyList2 = new List<int>();    // Khởi tạo 1 List các số nguyên và chỉ định Capacity ban đầu là 5

			/*
			Khởi tạo 1 List các số nguyên có kích thước bằng với MyList2
			Sao chép toàn bộ phần tử trong MyList2 vào MyList3
			 */
			List<int> MyList3 = new List<int>(MyList2);

			#endregion

			#region Sử dụng List

			// Tạo List các kiểu string và thêm 2 phần tử vào List
			List<string> MyList4 = new List<string>();
			MyList4.Add("Tran Dan");
			MyList4.Add("Hai Zu");

			// In giá trị các phần tử trong List
			WriteLine(" List ban dau");
			WriteLine(" So luong phan tu trong List la: {0}", MyList4.Count);
			foreach (var item in MyList4)
			{
				Write(" " + item);
			}
			WriteLine();

			// Chèn 1 phần tử vào đầu List
			MyList4.Insert(0, "3 Soc");

			// In lại các giá trị phần tử trong List để xem đã chèn được hay chưa
			WriteLine(" List sau khi insert");
			WriteLine(" So luong phan tu trong List la: {0}", MyList4.Count);
			foreach (var item in MyList)
			{
				Write(" " + item);
			}
			WriteLine();

			// Kiểm tra 1 phần tử có tồn tại trong List hay không
			bool isExists = MyList4.Contains("VNCH");

			if (!isExists)
			{
				WriteLine(" Khong tim thay chuoi VNCH trong List");
			}	
			else
			{
				WriteLine(" Tim thay");
			}	

			#endregion
		}
	}
}
