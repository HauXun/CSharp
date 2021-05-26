using System;
using System.Collections;
using static System.Console;

namespace ArrayLists
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Khởi tạo ArrayList
			ArrayList MyArray = new ArrayList();        // Khởi tạo 1 ArrayList rỗng

			ArrayList MyArray2 = new ArrayList(5);      // Khởi tạo 1 ArrayList và chỉ định Capacity ban đầu là 5

			/*
			Khởi tạo 1 ArrayList có kích thước bằng với MyArray2
			Sao chép toàn bộ phần tử trong MyArray2 vào MyArray3
			 */
			ArrayList MyArray3 = new ArrayList(MyArray2);
			#endregion

			#region Sắp xếp 1 danh sách object trong ArrayList
			ArrayList arrPerson = new ArrayList();

			arrPerson.Add(new Person("Nguyen Van A", 18));
			arrPerson.Add(new Person("Nguyen Van B", 25));
			arrPerson.Add(new Person("Nguyen Van C", 20));

			// In thử danh sách Person ban đầu ra
			WriteLine("Danh sach Person ban dau: ");
			foreach (var item in arrPerson)
			{
				WriteLine(item.ToString());
			}

			/*
			Thực hiện sắp xếp danh sách Person theo tiêu chí đã được định nghĩa
			trong phương thức Compare của lớp Person (tuổi tăng dần)
			 */


			// In danh sách Person đã được sắp xếp ra màn hình
			WriteLine();
			WriteLine("Danh sach Person ban dau: ");
			foreach (var item in arrPerson)
			{
				WriteLine(item.ToString());
			}
			#endregion
		}
	}
}
