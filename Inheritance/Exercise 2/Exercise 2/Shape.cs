using System;

namespace Exercise_2
{
	class Shape
	{
		protected int width;
		protected int height;

		public void setWidth(int width)
		{
			this.width = width;
		}

		public void setHeight(int height)
		{
			this.height = height;
		}
	}

	interface ICalculation
	{
		int GetPerimeter();
	}
}
