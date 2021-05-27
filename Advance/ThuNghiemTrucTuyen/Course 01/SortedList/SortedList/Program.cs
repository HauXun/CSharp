using System;
using System.Collections;
using static System.Console;

namespace SortedLists
{
	class Program
	{
		static void Main(string[] args)
		{
			#region MyRegion

			SortedList MySL = new SortedList();     // Khởi tạo 1 SortedList rỗng

			SortedList MySL2 = new SortedList(5);   // Khởi tạo 1 SortedList và chỉ định Capacity ban đầu là 5

			/*
			Khởi tạo 1 SortedList có kích thước bằng với MySL2
			Sao chép toàn bộ phần tử trong MySL2 vào MySL3
			 */
			SortedList MySL3 = new SortedList(MySL2);

			/*
			Mình định nghĩa 1 lớp PersonCompare có thực thi 1 interface IComparer
			Sau đó ovveride lại phương thức Compare
			Sử dụng lớp trên để truyền vào Constructor của SortedList
			 */
			SortedList MySL4 = new SortedList(new PersonComparer());

			/*
			Tạo 1 SortedList mới và sao chép các phần tử từ MySL3 đồng thời sắp xếp các phần tử lại
			theo cách sắp xếp được định nghĩa trong lớp PersonComparer
			 */
			SortedList MySL5 = new SortedList(MySL3, new PersonComparer());

			#endregion

			#region Ví dụ sử dụng SortedList
			// Tạo 1 SortedList và truyền vào cách sắp xếp các Key trong SortedList này.
			SortedList MySl6 = new SortedList(new PersonComparer());
			MySl6.Add(new Person("Tran Dan", 65), 66);
			MySl6.Add(new Person("Hai Zu", 59), 58);

			foreach (DictionaryEntry item in MySl6)
			{
				WriteLine(" Key: " + item.Key + "\tValue: " + item.Value);
			}

			#endregion
		}
	}
}
