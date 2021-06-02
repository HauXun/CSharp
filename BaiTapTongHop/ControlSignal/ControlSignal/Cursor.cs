using System;

namespace ControlSignal
{
	class Cursor
	{
		public static void ReturnCursor(Point point)
		{
			Console.SetCursorPosition(point.X, point.Y);
		}
	}
}