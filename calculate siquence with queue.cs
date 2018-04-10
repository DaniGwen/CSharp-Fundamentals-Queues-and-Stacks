using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Calculate_Sequence_with_Queue
{
	class Program
	{
		static void Main(string[] args)
		{
			long N = long.Parse(Console.ReadLine());
			Queue<long> queue = new Queue<long>();
			

			for (int i = 0; i < 17; i++)
			{
				queue.Enqueue(N + 1);
				queue.Enqueue(2 * N + 1);
				queue.Enqueue(N + 2);
				N = queue.Dequeue();
				Console.Write(N + " ");
			}
			for (int i = 0; i < 32; i++)
			{
				Console.Write(queue.Dequeue()+ " ");
			}
		}
	}
}
