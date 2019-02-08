using System;
namespace Factorial
{
    public class Factorial
    {
		public static void Main(string[] args)
        {
				Console.WriteLine("Enter a number: ");                          //ask user for a number
                int number = Convert.ToInt32(Console.ReadLine());               //convert user input from string to int
				long fact = getFactorial(number);                               //store value from function getFactorial in var fact
                Console.WriteLine("The Factorial for " + number + " = " + fact);//print out the value from the getFactorial function
                
	/**/}
        private static long getFactorial(int number)                            //recursive function for finding factorial
    	{
	    	if (number == 0)
		    {
			    return 1;                                                       //default case, if a use puts in 0 then the factorial should return 1 OR this also doubles as the basis for the other calculations
    		}
	    	return number * getFactorial(number - 1);                           //return the value
	    }
	}
}
