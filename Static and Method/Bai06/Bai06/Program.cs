using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
	class ArrayCalculator
	{
		public static int sumOfArray(int[] arr, int n)
		{
			int total = 0;
			for (int i = 0; i < n; i++)
				total += arr[i];
			return total;
		}
		public static double sumOfArray(double[] arr, int n)
		{
			double total = 0;
			for (int i = 0; i < n; i++)
				total += arr[i];
			return total;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			//Console.Write("Nhap so phan tu trong mang(Int32): ");
			//int n = Convert.ToInt32(Console.ReadLine());
			//int[] arr1 = new int[n];
			//Console.WriteLine(" Nhap cac phan tu trong mang: ");
			//for (int i = 0; i < n; i++)
			//{
			//	Console.Write("Phan tu - {0}: ", i);
			//	arr1[i] = Convert.ToInt32(Console.ReadLine());
			//}
			int[] arr1 = new int[]{3, 4, 2};
			double[] arr2 = new double[] { 1.3, 4.2, 6.7 };
			Console.WriteLine(ArrayCalculator.sumOfArray(arr1, arr1.Length));
			Console.WriteLine(ArrayCalculator.sumOfArray(arr2, arr2.Length));
			Console.ReadLine();
		}
	}
}
