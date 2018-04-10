using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Fibonacci
{
	class Program
	{
		public static long[] my_memo;

		static void Main(string[] args)
		{
			long num = long.Parse(Console.ReadLine());
			my_memo = new long[num + 1];
			Console.WriteLine(FibWithMemo(num));

		}
		static long FibWithMemo(long inputNum, bool with_memo = true)
		{
			
			if (with_memo)
			{
				if (my_memo[inputNum] != 0)
					return my_memo[inputNum];
			}

			if (inputNum == 0)
				return 0;
			if (inputNum == 1)
				return 1;

			my_memo[inputNum] = FibWithMemo(inputNum - 1, with_memo) + FibWithMemo(inputNum - 2, with_memo);
			return my_memo[inputNum];
		}
	}
}
