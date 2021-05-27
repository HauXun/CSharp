using System;
using System.Collections;
using static System.Console;

namespace BitArrays
{
	class Program
	{
		public static void PrintBit(BitArray MyBA, int Width)
		{
			int i = Width;
			foreach (bool item in MyBA)
			{
				if (i < 1)
				{
					i = Width;
					WriteLine();
				}
				i--;
				Write(item.GetHashCode());		// In ra 0 1 thay vì true false
			}
			WriteLine();
		}

		static void Main(string[] args)
		{
			#region Khai báo và khởi tạo BitArray

			/*
			Khởi tạo 1 BitArray có 10 phần tử
			Mỗi phần tử có giá trị mặc định 0 (false)
			 */
			BitArray MyBA = new BitArray(10);

			/*
			Khởi tạo 1 BitArray có 10 phần tử
			Mỗi phần tử có giá trị mặc định 0 (false)
			 */
			BitArray MyBA2 = new BitArray(10, true);

			// Khởi tạo 1 BitArray từ 1 mảng bool có sẵn
			bool[] MyBools = new bool[5] { true, false, true, true, false };
			BitArray MyBA3 = new BitArray(MyBools);     // 1 0 1 1 0

			// Khởi tạo 1 BitArray từ 1 mảng byte có sẵn
			byte[] MyBytes = new byte[5] { 1, 2, 3, 4, 5 };
			BitArray MyBA4 = new BitArray(MyBytes);

			// Kiểm thử. Uncomment để xem kết quả
			WriteLine(" So bit cua BitArray la {0}", MyBA4.Length);
			PrintBit(MyBA4, 8);

			// Khởi tạo 1 BitArray từ 1 mảng int có sẵn
			int[] MyInts = new int[5] { 1, 2, 3, 4, 5 };
			BitArray MyBA5 = new BitArray(MyInts);

			// Kiểm thử. Uncomment để xem kết quả
			// WriteLine(" So bit cua BitArray la {0}", MyBA5.Length);
			// PrintBit(MyBA5, 32);

			#endregion

			#region Ví dụ và sử dụng BitArray

			// Khởi tạo 1 BitArray từ mảng bool có sẵn
			bool[] MyBools2 = new bool[5] { true, false, true, true, false };
			BitArray MyBA6 = new BitArray(MyBools2);

			// Khởi tạo 1 BitArray có 2 phần tử và có giá trị mặc định là 1 (true)
			bool[] MyBool3 = new bool[] { false, true, true, false, false };
			BitArray MyBA7 = new BitArray(MyBool3);

			Write(" Gia tri cua MyBA6: ");
			PrintBit(MyBA6, 5);

			Write(" Gia tri cua MyBA7: ");
			PrintBit(MyBA7, 5);

			WriteLine(" Thuc hien cac phep toan AND, OR, NOT, XOR tren MyBA6, va MyBA7: ");

			// Thực hiện sao chép giá trị của MyBA6 ra để không làm thay đổi nó
			BitArray AndBit = MyBA6.Clone() as BitArray;
			AndBit.And(MyBA7);
			Write(" Ket qua cua phep toan AND: ");
			PrintBit(AndBit, 5);

			BitArray OrBit = MyBA6.Clone() as BitArray;
			OrBit.Or(MyBA7);
			Write(" Ket qua cua phep toan AND: ");
			PrintBit(OrBit, 5);

			BitArray NotBit = MyBA6.Clone() as BitArray;
			NotBit.Not();
			Write(" Ket qua cua phep toan AND: ");
			PrintBit(NotBit, 5);

			BitArray XorBit = MyBA6.Clone() as BitArray;
			XorBit.Xor(MyBA7);
			Write(" Ket qua cua phep toan AND: ");
			PrintBit(XorBit, 5);

			#endregion
		}
	}
}
