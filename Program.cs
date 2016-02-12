using System;

namespace calculation
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int a = 10;
			Console.WriteLine (a++);
			Console.WriteLine (++a);

			Console.WriteLine (a--);
			Console.WriteLine (--a);
		}
	}
}
