using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UseEvent
{
	class Point3
	{
		private int x;
		private int y;

		public int X
		{
			get => x;
			set
			{
				x = value;

				// Hàm ủy thác có tên tương ứng
				EventHandler<SizeEventArgs> handler = (EventHandler<SizeEventArgs>)Events[EventName[(int)EventNameE.OnValueChanging]];

				if (handler != null)
				{
					handler(this, new SizeEventArgs(this));
				}
			}
		}

		public int Y
		{
			get => y;
			set
			{
				y = value;

				// Hàm ủy thác có tên tương ứng
				EventHandler<SizeEventArgs> handler = (EventHandler<SizeEventArgs>)Events[EventName[(int)EventNameE.OnValueChanging]];

				if (handler != null)
				{
					handler(this, new SizeEventArgs(this));
				}
			}
		}

		public EventHandlerList Events = new EventHandlerList();

		public event EventHandler<SizeEventArgs> ValueChanged
		{
			add
			{
				Events.AddHandler(EventName[(int)EventNameE.OnValueChanging], value);
			}
			remove
			{
				Events.RemoveHandler(EventName[(int)EventNameE.OnValueChanged], value);
			}
		}

		public class SizeEventArgs : EventArgs
		{
			public Point3 NewPoint { get; set; }

			public SizeEventArgs(Point3 point)
			{
				NewPoint = new Point3(point.X, point.Y);
			}

			public override string ToString()
			{
				return "{" + NewPoint.X + "," + NewPoint.Y + "}";
			}
		}

		public Point3(int x, int y)
		{
			X = x;
			Y = y;
		}

		List<string> EventName = new List<string>()
		{
			"OnValueChanged",
			"OnValueChanging"
		};

		public enum EventNameE
		{
			OnValueChanged,
			OnValueChanging
		}
	}
}
