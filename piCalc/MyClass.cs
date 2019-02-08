/*
 * Name: Kevin George
 * Teac: Prof. Gordon
 * Clas: CST-135 900A
 * Date: Oct 8,  2018
 */
using System;
namespace piCalc
{
    public class MyClass
    {
        public void doCalc(double terms)        //I decided to contain my pi calculator in a class so that the main method would be neater
		{
			int count = 1;                      //count is what I use to change which calculation I do next. It is set to 1 so that it starts with the positive math first
		    double piVal = 0;                   //the value where the result of the calculation of Pi will be calculated is stored here                         
			for (double i = 1; i <= terms*2; i+=2)      //loop where the math is done, multiplying terms by 2 gives me a more consistent result, as of right now I'm not sure why. I also increment i by 2 so it should go i = 1,3,5,7...
			{
				if(count % 2 == 0)              //if the count val is even, do the subtraction math and increment count once
				{
                    piVal = piVal - 4/i;
					count++;
                }
				else                            //if the count val is even do the addition math and increment count once
                {                               
                    piVal = piVal + 4/i;
					count++;
                }           
			}
			Console.WriteLine("Calculating Pi to " + terms + " term(s) = " + Math.Round(piVal, 11));    //print result

			Console.WriteLine("");      //leave a space
            Console.WriteLine("Please enter a positive integer stating how many terms of Pi you want to calculate or type 'exit' to exit");               //show user their options
		}
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter a positive integer stating how many terms of Pi you want to calculate or type 'exit' to exit");               //show user their options
			string userInput = Console.ReadLine();      //read in whatever the user inputs
			while(userInput != "exit")                  //run the program as long as the user does not input 'exit'
			{            
				double calcVal;                         //double value created where the user input will be put into
				bool checkInput = double.TryParse(userInput, out calcVal);      //check if the user input is a number or text
				if(checkInput == true && calcVal > 0)               //if the bool checkInput is true and whatever number they enter is greater than 0 perform calculation
				{
					MyClass c1 = new MyClass();         //create a new object so that the class created above can be used
					c1.doCalc(calcVal);                 //put the data into the method of the class
				}
				else                         //otherwise let them know to put in data that can be used
				{
					Console.WriteLine("");
					Console.WriteLine("Please enter a positive integer stating how many terms of Pi you want to calculate or type 'exit' to exit");               //show user their options               
				}
				userInput = Console.ReadLine();             //continue reading the input and doing what the user wants
			}
		}
    }
}
