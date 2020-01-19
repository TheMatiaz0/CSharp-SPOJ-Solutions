using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class KC001
{
	static void Main ()
	{
		int num1 = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		int num3 = int.Parse(Console.ReadLine());

		Add(num1, num2, num3);
	}

	private static void Add (int num1, int num2, int num3)
	{
		Console.WriteLine(num1 + num2 + num3);
	}
}
