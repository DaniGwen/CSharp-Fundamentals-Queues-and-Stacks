using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Basic_Queue_Operations
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			Queue<int> queue = new Queue<int>();
			
			int N = input[0];
			int X = input[1];
			int Y = input[2];

			for (int i = 0; i < N; i++)
			{
				queue.Enqueue(nums[i]);
			}
			for (int i = 0; i < X; i++)
			{
				queue.Dequeue();
			}
			if (queue.Contains(Y))
			{
				Console.WriteLine("true");
			}
			else if (queue.Count == 0)
			{
				Console.WriteLine(0);
			}
			else
			{
				Console.WriteLine(queue.Min());
			}
		}
	}
}
