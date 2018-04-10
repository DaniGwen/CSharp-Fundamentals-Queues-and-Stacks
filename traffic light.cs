using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Traffic_Light
{
	class Program
	{
		static void Main(string[] args)
		{
			int numOfCarsToPass = int.Parse(Console.ReadLine());
			Queue<string> queue = new Queue<string>();
			string command = Console.ReadLine();
			int count = 0;

			while (command != "end")
			{
				if (command == "green")
				{
					for (int i = 0; i < numOfCarsToPass; i++)
					{
						Console.WriteLine($" {queue.Dequeue()} passed!");
						count++;
						if (queue.Count == 0)
						{
							break;
						}
					}
				}
				else
				{
					queue.Enqueue(command);
				}
				command = Console.ReadLine();
			}
			Console.WriteLine($"{count} cars passed the crossroads.");
		}
	}
}
