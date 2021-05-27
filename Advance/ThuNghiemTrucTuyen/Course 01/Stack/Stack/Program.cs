using System;
using System.Collections;
using static System.Console;

namespace Stacks
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Khai báo và khởi tạo Stack

			Stack MyStack = new Stack();    // Khởi tạo 1 Stack rỗng

			Stack MyStack2 = new Stack();   // Khởi tạo 1 Stack và chỉ định sức chứa ban đầu là 5

			// Khởi tạo 1 mảng bất kì
			ArrayList MyArray = new ArrayList();
			MyArray.Add(5);
			MyArray.Add(9);
			MyArray.Add(10);

			// Khởi tạo 1 Stack và sao chép các giá trị của các phần tử từ MyArray vào Stack
			Stack MyStack3 = new Stack(MyArray);

			#endregion

			#region Sử dụng Stack

			// Tạo 1 Stack rỗng
			Stack MyStack4 = new Stack();

			// Thực hiện thêm 1 vài phần tử vào Stack thông qua hàm Push
			MyStack4.Push("Tran Dan");
			MyStack4.Push("Son Tung");
			MyStack4.Push("Hai Zu");

			// Thử sử dụng các phương thức của Stack
			WriteLine(" So phan tu hien tai cua Stack la: {0}", MyStack4.Count);

			// Lưu ý ở đây ta chỉ muốn xem giá trị mà không muốn xóa nó khỏi Stack thì ta sẽ dùng Peek
			WriteLine(" Phan tu dau cua Stack la: {0}", MyStack4.Peek());

			// Thử kiểm tra lại số phần tử để chắc chắn rằng hàm Peek không xóa phần tử ra khỏi Stack
			WriteLine(" So phan tu cua Stack sau khi goi ham Peek: {0}", MyStack4.Count);

			//Thực hiện xóa các phần tử ra khỏi Stack
			WriteLine(" Popping...");
			int length = MyStack4.Count;
			for (int i = 0; i < length; i++)
			{
				Write(" " + MyStack4.Pop());
			}
			WriteLine();

			// Kiểm tra lại số phần tử của Stack sau khi Pop
			WriteLine(" So phan tu cua Stack sau khi Pop là: {0}", MyStack4.Count);

			#endregion
		}
	}
}
