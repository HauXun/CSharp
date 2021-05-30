using System;
using System.Collections.Generic;

namespace Bai01
{
	class CodeGenerator
	{
		const int LengthOfCode = 7;

		// Danh sách code đã tạo - Dùng danh sách này để để tránh bị trùng khi tạo ngẫu nhiên code mới
		static List<string> GenerotedCode = new List<string>();

		/// <summary>
		/// Sinh ra một code không trùng với code đã tồn tại
		/// </summary>
		/// <returns></returns>
		public static string GeneratorCode()
		{
			string result = "";
			while (true)
			{
				string code = "";

				// Sinh ngẫu nhiên code 7 ký tự
				Random rand = new Random();
				for (int i = 0; i < LengthOfCode; i++)
				{
					code += rand.Next(0, 10);
				}

				// Nếu code đã tồn tại thì sinh code mới
				if (!GenerotedCode.Contains(code) && code.Length == LengthOfCode)
				{
					GenerotedCode.Add(code);
					result = code;
					break;
				}
			}
			return result;
		}
	}
}