using System;

namespace Exercise_2
{
	class Rectangle : Shape,ICalculation
	{
		public int GetArea() => width * height;

		//public int GetPerimeter()
		//{
		//	throw new NotImplementedException();
		//}

		public int GetPerimeter() => (width + height) * 2;
	}
}
