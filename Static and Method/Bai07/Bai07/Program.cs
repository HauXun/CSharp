using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai07
{
	class ArrayCalculator
	{
		public static int maxOfArray(int[] arr, int n)
		{
			int maxValue = arr[0];
			for (int i = 1; i < n; i++)
				if(arr[i] > maxValue)
					maxValue = arr[i];
			return maxValue;
		}
		public static double maxOfArray(double[] arr, int n)
		{
			double maxValue = arr[0];
			for (int i = 1; i < n; i++)
				if (arr[i] > maxValue)
					maxValue = arr[i];
			return maxValue;
		}
		public static int minOfArray(int[] arr, int n)
		{
			int minValue = arr[0];
			for (int i = 1; i < n; i++)
				if (arr[i] < minValue)
					minValue = arr[i];
			return minValue;
		}
		public static double minOfArray(double[] arr, int n)
		{
			double minValue = arr[0];
			for (int i = 1; i < n; i++)
				if (arr[i] < minValue)
					minValue = arr[i];
			return minValue;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr1 = new int[] { 3, 4, 2 };
			double[] arr2 = new double[] { 1.3, 4.2, 6.7 };
			Console.WriteLine(" (Int32)Max of Array is: " + ArrayCalculator.maxOfArray(arr1, arr1.Length));
			Console.WriteLine(" (Double)Max of Array is: " + ArrayCalculator.maxOfArray(arr2, arr2.Length));
			Console.WriteLine("\n (Int32)Min of Array is: " + ArrayCalculator.minOfArray(arr1, arr1.Length));
			Console.WriteLine(" (Double)Min of Array is: " + ArrayCalculator.minOfArray(arr2, arr2.Length));
			Console.Read();
		}
	}
}
