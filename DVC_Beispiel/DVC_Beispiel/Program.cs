using System;

namespace DVC_Beispiel
{
	public class Program
	{
		static void Main(string[] args)
		{
			new Program().Run();
		}

		public Program()
		{

		}

		public void Run()
		{
			try
			{
				run();
			}
			catch(Exception e)
			{
				Console.WriteLine($"Failed to run programm: {e.Message}. Restarting...\n");
				Run();
			}
		}

		private void run()
		{
			Console.WriteLine("Enter two numbers you want to add.");
			Console.WriteLine("First number: ");
			string first = Console.ReadLine();
			Console.WriteLine("Second number: ");
			string second = Console.ReadLine();
			string result = addStringifiedNumbers(first, second);
			Console.WriteLine($"The result is: {result}");
			Console.WriteLine("See you later. (Press enter to terminate app)");
		}

		private string addStringifiedNumbers(string first, string second)
		{
			NumbersAdderFactory factory = new NumbersAdderFactory();
			NumbersAdder numbersAdder = factory.Create(first, second);
			numbersAdder.CalculateResult();
			return numbersAdder.Result;
		}


	}
}
