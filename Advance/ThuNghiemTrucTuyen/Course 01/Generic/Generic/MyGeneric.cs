using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
	class MyGeneric<T>
	{
		private T[] items;

		public T[] Items { get => items; }

		public MyGeneric(int size)
		{
			items = new T[size];
		}

		public T GetByIndex(int index)
		{
			// Nếu index vượt ra khỏi chỉ số phần tử của mảng thì ném ra ngoại lệ
			if (index < 0 || index > items.Length)
			{
				throw new IndexOutOfRangeException();
			}
			else
			{
				return items[index];

			}	
		}

		public void SetItemValue(int index, T value)
		{
			if (index < 0 || index > items.Length)
			{
				throw new IndexOutOfRangeException();
			}
			else
			{
				items[index] = value;
			}
		}
	}
}
