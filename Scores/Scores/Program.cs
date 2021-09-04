using System;

namespace Scores
{
	class Program
	{
		static void Main()
		{
			Console.Write("Please enter in your first name: ");
			string uName = Console.ReadLine();

			string date = DateTime.Today.ToShortDateString();

			string msg = $"\nWelcome back {uName}.  Today is {date}.";
			Console.WriteLine(msg);

			string path = @"C:\Users\jason\Documents\GitHub\C# Projects\Scores\Scores\studentScores.txt";
			string[] lines = System.IO.File.ReadAllLines(path);

			double tScore = 0.0;

			Console.WriteLine("\nStudent Scores:");
			foreach(string line in lines)
			{
				Console.Write("\n" + line);
				double score = Convert.ToDouble(line);
				tScore += score;
			}

			double avgScore = Math.Round(tScore / lines.Length * 100) / 100;

			Console.WriteLine("\n\nTotal of " + lines.Length + " student scores (average: " + avgScore + ")");

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}
