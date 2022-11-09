using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Delegate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> items = new List<int> { 8, 15, 26, 32, 35, 41, 100, 111 };
			Func<int, bool> isEven = n => n % 2 == 0;

			List<int> EvenItems = GetEvenItems(items, isEven);
			foreach (var item in EvenItems)
			{
				Console.WriteLine(item);
			}
			
			



		}
	
		static List<int> GetEvenItems(List<int> source, Func<int, bool> func)
		{
			var result = new List<int>();

			foreach (int item in source)
			{
				if (func(item) == true)
				{
					result.Add(item);
				}
			}

			return result;
		}
	}
	
}
