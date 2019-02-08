using System;
namespace PrimeCheck
{
    public class PrimeCheck
    {
		static void Main(string[] args)
        {
			Console.Out.WriteLine("Welcome to the prime number check system 5000");

			int value;
			int countCheck = 0;

			Console.Out.WriteLine("Enter a number to see if it is a prime number or not");
			value = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= value; i++)
			{
				if(value % i == 0)
				{
					countCheck++;
				}
			}

			if (countCheck == 2)
            {
                Console.WriteLine(value + " is a prime number");
            }
            else
            {
                Console.WriteLine(value + " is not a Prime Number");
            }
            Console.ReadLine();
        }
    }
}
