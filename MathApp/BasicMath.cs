using System;
using System.Collections.Generic;
using System.Text;

namespace MathApp
{
	public class BasicMath
	{
		public int Add(int num1, int num2)
		{
			int result = num1 + num2;
			return result;
		}
		public int Subtract(int num1, int num2)
		{
			int result = num1 - num2;
			return result;
		}
		public int Divide(int num1, int num2)
		{
			if (num1 == 0)
            {
				return num2;
            }
			else if (num2 == 0)
            {
				return num1;
            }

			int result = num1 / num2;
			return result;
		}
		public int Multiply(int num1, int num2)
		{
			int result = num1 * num2;
			return result;
		}
	}
}
