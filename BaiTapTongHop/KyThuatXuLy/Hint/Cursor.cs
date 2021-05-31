using System;

namespace Hint
{
	class Cursor
	{
		public static void ReturnCursor(Point point)
		{
			Console.SetCursorPosition(point.X, point.Y);
		}
	}
}