using System;
namespace fibonacciAndFactorial
{
    public class fibAndFact
    {
		public static void Main(string[] args)
        {
			string userInput;
			int factValue;
			int fibValue;
			Console.WriteLine("please enter 'fib' to calculate the Fibonacci Sequence or 'fact' to calculate a factorial or type 'exit' to exit");
			userInput = Console.ReadLine();
			while(userInput != "exit")
			{
				if(userInput == "fib")
				{
					string numberCheck;
					Console.WriteLine("Calculating Fibonacci Sequence");
					Console.WriteLine("");
					Console.WriteLine("Enter a positive number: ");
					double doubleFibVal = 0;
					double doubleFib;
					numberCheck = Console.ReadLine();
					bool result = int.TryParse(numberCheck, out fibValue);
					if(result == true)
					{
						if(fibValue > 0)
						{
							long fib = getFibonacci(0, 1, 1, fibValue);
							doubleFibVal = Math.Round(Convert.ToDouble(fibValue), 3);
							doubleFib = Math.Round(Convert.ToDouble(fib), 3);
							Console.WriteLine("The value at position " + String.Format("{0:#,0.000}", doubleFibVal) + " = " + String.Format("{0:#,0.000}", doubleFib));
							Console.WriteLine("enter 'fib' to calculate the Fibonacci Sequence or 'fact' to calculate a factorial or type 'exit' to exit");
						}
						else if(fibValue == 0)
						{
							Console.WriteLine("The value at position " + String.Format("{0:#,0.000}", doubleFibVal) + " = " + String.Format("{0:#,0.000}", 0));
                            Console.WriteLine("enter 'fib' to calculate the Fibonacci Sequence or 'fact' to calculate a factorial or type 'exit' to exit");
						}
						else
						{
							Console.WriteLine("This only works if you put in a positive integer");
							Console.WriteLine("enter 'fib' to calculate the Fibonacci Sequence or 'fact' to calculate a factorial or type 'exit' to exit");
						}
					}
					else
					{
						Console.WriteLine("This only works if you put in a positive integer");
						Console.WriteLine("enter 'fib' to calculate the Fibonacci Sequence or 'fact' to calculate a factorial or type 'exit' to exit");
					}
				}
				else if (userInput == "fact")
				{
					string factNumCheck;
					double doubleFactVal = 0;
					double doubleFact;
					Console.WriteLine("Calculating Factorial");               
					Console.WriteLine("");
                    Console.WriteLine("Enter a positive number: ");
					factNumCheck = Console.ReadLine();
					bool factResult = int.TryParse(factNumCheck, out factValue);
					if(factResult == true)
					{
						if(factValue > 0)
						{
							long fact = getFactorial(factValue);
							doubleFactVal = Math.Round(Convert.ToDouble(factValue), 3);
							doubleFact = Math.Round(Convert.ToDouble(fact), 3);
							Console.WriteLine("The Factorial for " + String.Format("{0:#,0.000}", doubleFactVal) + " = " + String.Format("{0:#,0.000}", doubleFact));
							Console.WriteLine("enter 'fib' to calculate the Fibonacci Sequence or 'fact' to calculate a factorial or type 'exit' to exit");
						}
						else if (factValue == 0)
                        {
							Console.WriteLine("The Factorial for " + String.Format("{0:#,0.000}", doubleFactVal) + " = " + String.Format("{0:#,0.000}", 0));
                            Console.WriteLine("enter 'fib' to calculate the Fibonacci Sequence or 'fact' to calculate a factorial or type 'exit' to exit");
                        }
						else
                        {
                            Console.WriteLine("This only works if you put in a positive integer");
                            Console.WriteLine("enter 'fib' to calculate the Fibonacci Sequence or 'fact' to calculate a factorial or type 'exit' to exit");
                        }
					}
					else
                    {
                        Console.WriteLine("This only works if you put in a positive integer");
                        Console.WriteLine("enter 'fib' to calculate the Fibonacci Sequence or 'fact' to calculate a factorial or type 'exit' to exit");
                    }
				}
				else
				{
					Console.WriteLine("please enter 'fib' to calculate the Fibonacci Sequence or 'fact' to calculate a factorial  or type 'exit' to exit");
				}
				userInput = Console.ReadLine();            
			}

        }

		private static long getFactorial(int number)                            //recursive function for finding factorial
        {
            if (number == 0)
            {
                return 1;                                                       //default case, if a use puts in 0 then the factorial should return 1 OR this also doubles as the basis for the other calculations
            }
            return number * getFactorial(number - 1);                           //return the value
        }

		private static long getFibonacci(int a, int b, int iterator, int givenLimit)
        {
            if (iterator <= givenLimit)
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