using System;
using System.Collections;

namespace SortedLists
{
	class PersonComparer : IComparer
	{
		public int Compare(object x, object y)
		{
			// Ép kiểu 2 object truyền vào về Person
			Person p1 = x as Person;
			Person p2 = y as Person;

			/*
			Vì có thể 2 object truyền vào không phải Person khi đó ta không thể so sánh được.
			Trường hợp này tốt nhất là chúng ta nên ném ra lỗi để lập trình viên sửa chữa.
			 */
			if (p1 == null || p2 == null)
			{
				throw new InvalidOperationException();
			}
			else
			{
				/*
				Khi dữ liệu đã ok thì ta thực hiện so sánh và trả về các giá trị 1 0 -1 tương ứng
				lớn hơn, bằng, bé hơn
				 */
				if (p1.Age < p2.Age)
				{
					return 1;
				}
				else if (p1.Age > p2.Age)
				{
					return -1;
				}
				else
				{
					return 0;
				}
			}
		}
		}
	}
