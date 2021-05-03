using static System.Console;

namespace Bai01
{
	class Program
	{
		static void Main(string[] args)
		{
			First.A a = new First.A();
			a.Display();
			Third.Second.A a2 = new Third.Second.A();
			a2.Display();
			ReadKey();
		}
	}
}

namespace First
{
	class A
	{
		public void Display()
		{
			WriteLine("This is a class A in First");
		}
	}
}

namespace Third
{
	namespace Second
	{
		class A
		{
			public void Display()
			{
				WriteLine("This is a class A in Second");
			}
		}
	}

}