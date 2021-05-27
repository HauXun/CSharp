using System;
using System.Collections;
using static System.Console;

namespace Queues
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Khai báo và khởi tạo Queue

			Queue MyQueue = new Queue();    // Khởi tạo 1 Queue rỗng

			Queue MyQueue2 = new Queue();   // Khởi tạo 1 Queue và chỉ định sức chứa ban đầu là 5

			// Khởi tạo 1 mảng bất kì
			ArrayList MyArray = new ArrayList();
			MyArray.Add(5);
			MyArray.Add(9);
			MyArray.Add(10);

			// Khởi tạo 1 Queue và sao chép giá trị của các phần tử từ MyArray vào Queue
			Queue MyQueue3 = new Queue(MyArray);

			#endregion

			#region Ví dụ sử dụng Queue

			// Tạo 1 Queue rỗng
			Queue MyQueue4 = new Queue();

			// Thực hiện thêm vài phần tử vào Queue thông qua hàm EnQueue
			MyQueue4.Enqueue("Tran Dan");
			MyQueue4.Enqueue("Son Tung");
			MyQueue4.Enqueue("Hai Zu");

			// Thử sử dụng các phương thức của Queue
			WriteLine(" So phan tu hien tai cua Queue la: {0}", MyQueue4.Count);

			// Lưu ý ở đây ta chỉ muốn xem giá trị mà không muốn xóa nó khỏi Queue thì ta sẽ dùng Peek
			WriteLine(" Phan tu dau cua Queue la: {0}", MyQueue4.Peek());

			// Thử kiểm tra lại số phần tử để chắc chắn rằng hàm Peek không xóa phần tử ra khỏi Queue
			WriteLine(" So phan tu cua Queue sau khi goi ham Peek: {0}", MyQueue4.Count);

			// Thực hiện xóa các phần tử ra khỏi Queue thông qua hàn Dequeue
			WriteLine(" Popping...");
			int length = MyQueue4.Count;
			for (int i = 0; i < length; i++)
			{
				Write(" " + MyQueue4.Dequeue());
			}
			WriteLine();

			// Kiểm tra lại số phần tử của Queue sau khi Pop
			WriteLine(" So phan tu cua Queue sau khi Pop la: {0}", MyQueue4.Count);

			#endregion
		}
	}
}
