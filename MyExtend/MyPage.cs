using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyExtend
{
	public static class MyExtend
	{
		public static int[] FindDuplicateNumber(this int[] numbers)
		{
			Dictionary<int, int> duplicateNumbers = new Dictionary<int, int>();
			foreach (var number in numbers)
			{
				if (duplicateNumbers.ContainsKey(number))
				{ duplicateNumbers[number]++; }
				else
				{ duplicateNumbers.Add(number, 1); }
			}
			return duplicateNumbers.Where(i => i.Value >= 2).Select(i => i.Key).ToArray();
		}
	}
}
