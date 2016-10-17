using System;

namespace Factorialnumber
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int val;
			int factorialval = 1;
			string input;

			Console.WriteLine("Enter a number");
			input = Console.ReadLine();
			val = int.Parse(input);

			for (int i = 1; i <= val; i++)
			{
				factorialval *= i;

			}

			Console.WriteLine("This is the factorial number is " + factorialval);
		}
	}
}
