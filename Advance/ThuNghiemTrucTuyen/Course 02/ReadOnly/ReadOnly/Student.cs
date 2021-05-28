using System;

namespace ReadOnly
{
	class Student
	{
		public readonly string name;    // Chỉ đọc

		// Có thể được gán thông qua Constructor
		public Student(string name)
		{
			this.name = name;
		}
	}
}
