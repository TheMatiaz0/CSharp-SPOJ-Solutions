using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// RNO_DOD - Proste dodawanie
// https://pl.spoj.com/problems/RNO_DOD

public class RNO_DOD
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
			string input = Console.ReadLine();
			string[] words = Console.ReadLine().Split();
			int finalNumber = 0;

			for (int z = 0; z < int.Parse(input); z++)
			{
				int toAdd = int.Parse(words[z]);
				finalNumber += toAdd;
			}

			Console.Write($"{finalNumber}\n");
		}
	}
}
