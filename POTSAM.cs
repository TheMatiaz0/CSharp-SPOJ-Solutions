using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// POTSAM - Samolot
// https://pl.spoj.com/problems/POTSAM

public class POTSAM
{
	static void Main()
	{
		string input = Console.ReadLine();
		string[] words = input.Split(null);

		int n1 = int.Parse(words[0]);
		int k1 = int.Parse(words[1]);
		int n2 = int.Parse(words[2]);
		int k2 = int.Parse(words[3]);

		Console.Write((n1 * k1) + (n2 * k2));
	}
}
