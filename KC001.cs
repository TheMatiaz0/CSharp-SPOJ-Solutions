using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// KC001 - Dodawanie liczb całkowitych
// https://pl.spoj.com/problems/KC001

public class KC001
{
	static void Main()
	{
		int num1 = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		int num3 = int.Parse(Console.ReadLine());

		Console.Write(Add(num1, num2, num3));
	}

	/// <summary>
	/// Add three integers and return sum.
	/// </summary>
	/// <param name="num1"></param>
	/// <param name="num2"></param>
	/// <param name="num3"></param>
	/// <returns></returns>
	private static int Add(int num1, int num2, int num3)
	{
		return num1 + num2 + num3;
	}
}
