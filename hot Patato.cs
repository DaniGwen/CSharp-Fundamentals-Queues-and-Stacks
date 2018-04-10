﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hot_Patato
{
	class Program
	{
		static void Main(string[] args)
		{
			var children = Console.ReadLine().Split(' ');
			int n = int.Parse(Console.ReadLine());
			Queue<string> queue = new Queue<string>(children);

			while (queue.Count != 1)
			{
				for (int i = 1; i < n; i++)
				{
					queue.Enqueue(queue.Dequeue());
				}
				Console.WriteLine($"Removed {queue.Dequeue()}");
			}
			Console.WriteLine($"Last in {queue.Dequeue()}");
		}
	}
}
