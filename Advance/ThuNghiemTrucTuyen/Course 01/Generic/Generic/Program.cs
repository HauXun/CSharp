using System;

namespace Generic
{
	class Program
	{
		public static void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}

		public static void Swap<T>(ref T a, ref T b)
		{
			T temp = a;
			a = b;
			b = temp;
		}

		static void Main(string[] args)
		{
			#region Generic cho phương thức

			int a = 5, b = 7;
			double c = 1.2, d = 5.6;

			Swap<int>(ref a, ref b);
			Swap<double>(ref c, ref d);

			#endregion

			#region Generic cho lớp

			// Khởi tạo 1 mảng số nguyên kiểu int có 5 phần tử
			MyGeneric<int> MyG = new MyGeneric<int>(5);

			MyG.SetItemValue(0, 10);

			#endregion
		}
	}
}
