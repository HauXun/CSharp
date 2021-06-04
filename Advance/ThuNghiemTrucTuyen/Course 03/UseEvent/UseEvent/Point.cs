using System;

namespace UseEvent
{
	class Point
	{
		private int x;
		private int y;

		public int X 
		{
			get => x;
			set
			{
				x = value;
				if (_ValueChanged != null)
				{
					_ValueChanged(this, new EventArgs());
				}
			}
		}
		public int Y
		{ 
			get => y;
			set
			{
				y = value;
				if (_ValueChanged != null)
				{
					_ValueChanged(this, new EventArgs());
				}
			}
		}

		private event EventHandler _ValueChanged;
		public event EventHandler ValueChanged
		{
			add
			{
				_ValueChanged += value;
			}
			remove
			{
				_ValueChanged -= value;
			}
		}

		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}
	}
}
