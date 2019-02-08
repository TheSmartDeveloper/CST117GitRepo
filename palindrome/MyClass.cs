/*
 * Name: Kevin George
 * Teac: Prof. Gordon
 * Clas: CST-135 900A
 * Date: Sep 28, 2018
 */
using System;
namespace palindrome
{
    public class MyClass
    {
		private static string palindromeClass(string inputString)               //I decided to make a class to build up my class building skills and also to separate the palindrome method from the main method
        {
			char[] word = inputString.ToCharArray();                            //create a new character array out of the word with the size of the word
			Array.Reverse(word);                                                //use C# array.reverse function to reverse array
			string Reverse = new string(word);                                  //put the reversed array into another string
			if(Reverse == inputString)                                          //compare OG string with reversed string
			{
				Console.WriteLine(inputString + " is a palindrome!");           //tell user good news
				return " ";
			}
			else
			{
				Console.WriteLine(inputString + " is not a palindrome");        //tell user bad news
				return " ";
			}
        }

		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter some text to see if it is a palindrome, or type 'exit' to exit");   //tell user what to do
			string userInput;                                                   //var for stringInput
			userInput = Console.ReadLine();                                     //set what the user puts in into userInput var
			while(userInput != "exit")                                          //check to see if the user wants to exit the program
			{
				string word = palindromeClass(userInput);                       //string var of class created
				Console.WriteLine(word);                                        //print out the method
				Console.WriteLine("Please enter some text to see if it is a palindrome, or type 'exit' to exit");      //tell user what to do
				userInput = Console.ReadLine();                                 //see if the user wants to write anything else or check if they want to exit
			}
		}
    }
}
