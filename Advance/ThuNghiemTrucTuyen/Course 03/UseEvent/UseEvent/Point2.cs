using System;

namespace UseEvent
{
	class Point2
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
					_ValueChanged(this, new SizeEventArgs(this));
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
					_ValueChanged(this, new SizeEventArgs(this));
				}
			}
		}

		public Point2(int x, int y)
		{
			X = x;
			Y = y;
		}

		private event EventHandler<SizeEventArgs> _ValueChanged;
		public event EventHandler<SizeEventArgs> ValueChanged
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

		public class SizeEventArgs : EventArgs
		{
			public Point2 NewPoint { get; set; }

			public SizeEventArgs(Point2 point)
			{
				NewPoint = new Point2(point.X, point.Y);
			}

			public override string ToString()
			{
				return "{" + NewPoint.X + "," + NewPoint.Y + "}";
			}
		}
	}
}