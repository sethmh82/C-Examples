using System;

namespace dataTypes
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int Adam_Balance = 200;
			int Seth_Balance = -30;

			uint Adam_Age = 20;
			uint Seth_Age = 35;

			Console.WriteLine("Hey I am writing code");
			Console.WriteLine(Adam_Balance);
			Console.WriteLine(Seth_Balance);

			Console.WriteLine("max value of int is {0}", int.MaxValue);
			Console.WriteLine("max value of int is {0}", int.MinValue);

			Console.WriteLine("max value of int is {0}", uint.MaxValue);
			Console.WriteLine("max value of int is {0}", uint.MinValue);

			// Fractions

			float float_number = 2.56f;
			double double_number = 16.555;
			decimal decimal_number = 7000.8888M;

			Console.WriteLine(float_number);
			Console.WriteLine(double_number);
			Console.WriteLine(decimal_number);

			Console.WriteLine ("max value of float is {0}", float.MaxValue);
			Console.WriteLine ("max value of float is {0}", float.MinValue);

			Console.WriteLine ("Fun with float {0}", float.NaN);

			// III Logical

			bool logical_true = true;
			bool logical_false = false;

			Console.WriteLine(logical_true);
			Console.WriteLine(logical_false);

			// IV Texts

			char c = 'c';
			char one = '1';
			char symbol = '?';

			Console.WriteLine(c);
			Console.WriteLine(one);
			Console.WriteLine(symbol);

			string text = "Whatever you have to say";

			Console.WriteLine(text);



			Console.ReadLine();


		}
	}
}
