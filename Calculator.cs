using System;
namespace CSharp_intermediate
{
	public class Calculator
	{

		// the params modifier in a method
		public int Add(params int[] numbers)
		{
			var sum = 0;
			foreach (var num in numbers)
			{
				sum += num;
			}
			return sum;
		}
	}
}

