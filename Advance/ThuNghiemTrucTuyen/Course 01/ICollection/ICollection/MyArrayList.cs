using System;
using System.Collections;

namespace ICollections
{
	class MyArrayList : ICollection
	{
		private object[] lstObj;    // Mảng giá trị
		private int count;          // Số lượng phần tử
		private const int MAXCOUNT = 100;   // Số lượng phần tử tối đa

		public MyArrayList()
		{
			count = -1;
			lstObj = new object[MAXCOUNT];
		}

		public MyArrayList(int count)
		{
			this.count = count;
			lstObj = new object[count];
		}

		public MyArrayList(Array array)
		{
			array.CopyTo(lstObj, 0);
			count = array.Length;
		}
		public void CopyTo(Array array, int index)
		{
			// Thực hiện copy các phần tử trong lstObj từ vị trí index đến cuối sang mảng Array.
			lstObj.CopyTo(array, index);
		}



		public int Count { get => count; }

		public bool IsSynchronized => throw new NotImplementedException();

		public object SyncRoot => throw new NotImplementedException();


		public IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
