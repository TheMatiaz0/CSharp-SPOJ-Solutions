using System;

// PP0501A - NWD
// https://pl.spoj.com/problems/PP0501A

public class PP0501A
{
	static void Main()
	{
		// t is used for number of tests
		int t = int.Parse(Console.ReadLine());
		Start(t);
	}

	public static void Start(int loop)
	{
		for (int i = 0; i < loop; i++)
		{
			// Next, you have to type two numbers splitted by whitespace:
			string input = Console.ReadLine();
			string[] words = input.Split(null);
			int a = int.Parse(words[0]);
			int b = int.Parse(words[1]);

			Console.WriteLine(Nwd(a, b));
		}
	}

	/// <summary>
	/// Calculation of greatest common divisor
	/// </summary>
	/// <param name="a">First number</param>
	/// <param name="b">Second number</param>
	/// <returns></returns>
	public static int Nwd(int a, int b)
	{
		if (b == 0)
		{
			return a;
		}

		int c = (a % b);
		return Nwd(b, c);
	}
}