using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Recursive_Fibonacci
{
	class Program
	{
		static void Main(string[] args)
		{
			long n = long.Parse(Console.ReadLine());
			Console.WriteLine( FibWithLoop(n));
		}

		 static  long FibWithLoop(long counter)
		{
			long f1 = 1;
			long f2 = 1;
			long f_result = 0;

			// щото каунтъра ни почва от 2 и не смята първите итерации трябва се хардкодне.
			if (counter == 1)
			{
				return 1;
			}
			else if (counter == 2)
			{
				return 1;
			}

			for (int i = 2; i < counter; i++)
			{
				f_result = f1 + f2;
				f1 = f2;
				f2 = f_result;
			}
			
			return f_result;
		}
	}
}
