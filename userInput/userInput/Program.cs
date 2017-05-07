using System;

namespace userInput
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please Enter Your Name:");
			string name = Console.ReadLine();
			Console.WriteLine("Your name is: {0}", name);

			Console.WriteLine("Please enter your age:");
			int age = int.Parse(Console.ReadLine()); // Console always returns a string so you need to Parse it
			Console.WriteLine("Your age is: {0}", age);

			Console.WriteLine("Please enter a double number:");
			double ratio = double.Parse(Console.ReadLine()); 
			Console.WriteLine("Your ratio is: {0}", ratio);

			Console.WriteLine("Can you write code in C#?");
			bool canCode = bool.Parse(Console.ReadLine());
			Console.WriteLine("You can code? The answer is: {0}", canCode); 

			Console.ReadLine();
		}
	}
}
