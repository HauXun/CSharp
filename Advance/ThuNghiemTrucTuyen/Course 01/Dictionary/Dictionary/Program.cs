using System;
using System.Collections.Generic;
using static System.Console;

namespace Dictionarys
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Khai báo và khởi tạo Dictionary

			// Khởi tạo 1 Dictionary rỗng với Key và Value đều có kiểu dữ liệu chuỗi
			Dictionary<string, string> MyDic = new Dictionary<string, string>();

			/*
			Khởi tạo 1 Dictionary với Key và Value có kiểu chuỗi
			đồng thời chỉ định Capacity ban đầu là 5
			 */
			Dictionary<string, string> MyDic2 = new Dictionary<string, string>(5);

			/*
			Khởi tạo 1 Dictionary có kích thước bằng với MyDic2
			Sao chép toàn bộ phần tử trong MyDic2 vào MyDic3
			 */
			Dictionary<string, string> MyDic3 = new Dictionary<string, string>(MyDic2);

			#endregion

			#region Sử dụng Dictionary

			#endregion
		}
	}
}
