using System;

namespace customDataTypes
{

	class Person
	{
		public string ID;
		public string Name;
		public int Age;

		public Person(string _id, string _name, int _age)
		{
			ID = _id;
			Name = _name;
			Age = _age;
		}

		public override string ToString()
		{
			return String.Format("ID: {0}, Name: {1}, Age: {2}", ID, Name, Age);
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{

			Person guy = new Person("W5W4W3", "Seth", 35);
			guy.Age += 1;

			Console.WriteLine(guy);
			Console.WriteLine(guy.GetType());
			Console.WriteLine(typeof(Person));

			Console.Read();

		}
	}
}