using System;
namespace Fibonacci
{
    public class Fibonacci
    {
		public static void Main(string[] args)
        {

            Console.WriteLine("Enter a number: ");                              //ask user for a number
            int number = Convert.ToInt32(Console.ReadLine());                   //convert user input from string to int
            long fib = getFibonacci(0,1,1, number);                                   //store value from function getFactorial in var fact
			Console.WriteLine("The value at position " + number + " = " + fib);    //print out the value from the getFactorial function
			Console.ReadKey();
        }

		private static long getFibonacci(int a, int b, int iterator, int givenLimit)
		{
			
			if(iterator <= givenLimit)
			{
				Console.Write(a);
				Console.Write(", ");
				return getFibonacci(b, a + b, iterator + 1, givenLimit);
			}
			long longVal = b - a;
			return longVal;
		}
    }
}
