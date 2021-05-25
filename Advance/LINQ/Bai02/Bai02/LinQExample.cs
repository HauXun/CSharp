using System;
using System.Linq;
using static System.Console;

namespace Bai02
{
	class LinQExample
	{
		public static void queryIntNumber()
		{
			// 1. Data Source
			int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			// 2. Query Creation
			var queryResult = from number in numbers
							  where (number % 2) == 0
							  select number;

			// 3. Query Execution
			foreach (var number in queryResult)	// IEnumrable<int>
			{
				Write($"{number} ");
			}

			WriteLine("\nConvert query's result to array");
			var arrayOfNumber = queryResult.ToArray();
			foreach (var number in arrayOfNumber) // This is a array
			{
				Write($"{number} ");
			}

			WriteLine("\nConvert query's result to list");
			var listOfNumber = queryResult.ToArray();
			foreach (var number in listOfNumber) // This is a list
			{
				Write($"{number} ");
			}
			WriteLine("\nEnd of conversion !");
		}
	}
}
