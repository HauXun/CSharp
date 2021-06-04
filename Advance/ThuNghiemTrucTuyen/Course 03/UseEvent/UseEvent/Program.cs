using System;
using System.Text;
using static System.Console;

namespace UseEvent
{
	class Program
	{
		static void Main(string[] args)
		{
			OutputEncoding = Encoding.Unicode;

			Point3 point = new Point3(0, 0);

			point.ValueChanged += Point_ValueChanged;

			point.X++;
			WriteLine("State {2} - {0} | {1}", point.X, point.Y, 3);
			point.Y++;
			WriteLine("State {2} - {0} | {1}", point.X, point.Y, 4);
		}

		private static void Point_ValueChanged(object sender, Point3.SizeEventArgs e)
		{
			WriteLine(e.ToString());
		}
	}
}
