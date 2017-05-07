using System;

namespace simpleOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, what's up? What is your favorite number?");
			double favoriteNumber = double.Parse(Console.ReadLine());
			Console.WriteLine("see your favorite number is: {0}", favoriteNumber);

			double doubleOfFavorite = favoriteNumber * 2;
			double halfOfFavorite = favoriteNumber / 2;

			Console.WriteLine("Double of your favorite: {0}", doubleOfFavorite);
			Console.WriteLine("Half of your favorite: {0}", halfOfFavorite);

			//Incrementation

			double counter = 0;
			Console.WriteLine("The state of counter {0}", counter);
			counter = counter + 1;
			Console.WriteLine("The state of counter {0}", counter);
			counter += 10;
			Console.WriteLine("The state of counter {0}", counter);

			// Subtraction "Decrementation"

			counter = counter - 1;
			Console.WriteLine("The state of counter {0}", counter);
			counter -= 10;
			Console.WriteLine("The state of counter {0}", counter);

			//Multiplication Division

			counter = 10;
			counter *= 3;
			Console.WriteLine("The state of counter {0}", counter);
			counter /= 2;
			Console.WriteLine("The state of counter {0}", counter);

			// Division with Remainder

			int r_1 = 10 % 2;

			Console.WriteLine("Remainder division");
			Console.WriteLine("10 % 2 = {0}", r_1);

			int r_2 = 10 % 3;
			Console.WriteLine("Remainder division");
			Console.WriteLine("10 % 3 = {0}", r_2);

			Console.ReadLine();
		}
	}
}
