using System;

namespace conditions
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Conditions

			int x = int.Parse(Console.ReadLine());

			if (x == 10)
			{
				Console.WriteLine("You typed ten");
			}
			else
			{
				Console.WriteLine("No ten here sorry bro");
			}

			Console.ReadLine();
		}
	}
}
