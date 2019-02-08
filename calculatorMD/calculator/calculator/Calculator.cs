
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class MyClass
    {
		static void Main(string[] args)
		{
			int num1;   //two integer vars created for summing
			int num2;

			Console.WriteLine("Please enter the first number");     //ask user for and read in first value
			num1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Please enter the next number");     //ask user for and read in second value
            num2 = Convert.ToInt32(Console.ReadLine());

			int sum = num1 + num2;      //created sum var and assigned it the sum of var num1 and var num2
			Console.WriteLine(num1 + " + " + num2 + " = " + sum);     //display value of sum for user

			//Console.ReadKey(ConsoleKey());      
			Console.WriteLine("Press ENTER to close console......");    //keep the terminal up until a key is pressed
            String line = Console.ReadLine();

            if (line == "enter")
            {
                System.Environment.Exit(0);
            }
		}
    }
}
/*
 * 
 * */