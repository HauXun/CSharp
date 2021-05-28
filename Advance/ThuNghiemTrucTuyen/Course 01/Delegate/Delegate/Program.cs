using System;
using System.Text;
using static System.Console;

namespace Delegate
{
	class Program
	{
		delegate int MyDelegate(string s);
		static void Main(string[] args)
		{
			OutputEncoding = Encoding.UTF8;

			MyDelegate convertToInt = new MyDelegate(ConvertStringToInt);
			MyDelegate showString = new MyDelegate(ShowString);
			MyDelegate multiCast = convertToInt + showString;

			string numberStr = "35";

			//int valueConverted = convertToInt(numberStr);
			//WriteLine("Giá trị đã convert thành int: " + valueConverted);

			WriteLine("Kết quả khi gọi multicast delegate");
			multiCast(numberStr);

			//multiCast -= showString;

			//NhapVaShowTen(showString);
		}

		static void NhapVaShowTen(MyDelegate showTen)
		{
			Write("Mời nhập tên của bạn >> ");
			string ten = ReadLine();
			showTen(ten);
		}

		static int ConvertStringToInt(string stringValue)
		{
			int valueInt = 0;
			Int32.TryParse(stringValue, out valueInt);
			WriteLine("Đã ép kiểu dữ liệu thành công");
			return valueInt;
		}

		static int ShowString(string stringValue)
		{
			WriteLine(stringValue);
			return 0;
		}
	}
}
