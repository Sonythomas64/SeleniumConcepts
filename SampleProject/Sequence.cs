using System;

namespace SampleProject
{
	class Sequence
	{
		public static void Main1(string[] args)
		{
			int i = 1, n = 3, product;

				do
				{
					product = n * i;
					Console.WriteLine("{0} * {1} = {2}", n, i, product);
					i++;

				} while (i <= 20);

		}
	}


}
