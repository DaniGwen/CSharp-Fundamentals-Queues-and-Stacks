using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Basic_Queue_Operations
{
	class StartUp
	{
		static void Main()
		{
			var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int n = input[0];
			int s = input[1];
			int x = input[2];

			Queue<int> que = new Queue<int>();

			var elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

			for (int i = 0; i < n; i++)
			{
				que.Enqueue(elements[i]);
			}

			for (int i = 0; i < s; i++)
			{
				que.Dequeue();
			}

			foreach (var item in que)
			{
				if (x == item)
				{
					Console.WriteLine("true");
					return;
				}
			}

			if (que.Count == 0)
			{
				Console.WriteLine(0);
			}
			else
			{
				var minNum = que.Min();

				Console.WriteLine(minNum);
			}
		}
	}
}
