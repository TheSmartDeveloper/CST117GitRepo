/*
 * Kevin George
 * Prof. Gordon
 * CST-117
 * Dec 16, 2018
 */
using System;
namespace OCA5
{
    public class MyClass
    {
        public MyClass()
        {
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Magic Number Calculator");
            Console.WriteLine(" ");
            Console.WriteLine("Enter how high you want to be or type 'exit' to exit");
            //read in what the user writes
            string nCheck = Console.ReadLine();
           
            //I wanted to check every single case for exit but it wasn't working properly
            //check that the user has not typed exit
            while(nCheck != "exit" /*|| nCheck != "exiT" || nCheck != "exIt" || nCheck != "exIT" || nCheck != "eXit" || nCheck != "eXiT" || nCheck != "eXIt" || nCheck != "eXIT" || nCheck != "Exit" || nCheck != "ExiT" || nCheck != "ExIt" || nCheck != "ExIT" || nCheck != "EXit" || nCheck != "EXiT" || nCheck != "EXIt" || nCheck != "EXIT"*/)
            {
                //nValue will be the length of the array
                int nValue;

                //check to see if user input can be made an integer and if so set it's value to nValue
                bool checkVal = int.TryParse(nCheck, out nValue);

                //if the bool returns true and nValue is a positive integer
                if(checkVal == true && nValue > 0)
                {
                    //array initialized
                    int[] bigArray = new int[nValue];
                    //count value that will be input into the array and incremented with each loop iteration
                    int count = 1;

                    //add each incremented value into each indice of the array
                    for (int i = 0; i < nValue; i++)
                    {
                        bigArray[i] = count++;
                    }

                    //----------------------------------------------------------
                    //code obtained from http://www.guideforschool.com/338-program-for-generating-lucky-numbers-isc-2001-method-1/
                    //decrementer will increase until it is equal to the size of the array

                    int incrementer = 1;
                    //once decrementer passes the value of the array length the while loop breaks
                    while (incrementer < nValue)
                    {
                        //i starts at the same value as incrementer but increases until it surpasses nValue
                        for (int i = incrementer; i < nValue; i += incrementer)
                        {
                            //increment j linearly
                            for (int j = i; j < nValue - 1; j++)
                            {
                                //change the previous element in the array with the next element in the array
                                bigArray[j] = bigArray[j + 1];
                            }
                            //decrement nValue increasing how quickly it equalizes with incrementer
                            nValue--;
                        }
                        //incrementer...does...well...can you guess?
                        incrementer++;
                    }
                    //----------------------------------------------------------
                    //print out the array
                    for (int k = 0; k < nValue; k++)
                    {
                        Console.Write(bigArray[k] + " ");
                    }
                    Console.WriteLine();

                }
                //let the user know that they need to use positive integers
                else
                {
                    Console.WriteLine("Please use a positive integer");
                    Console.WriteLine(" ");
                }
                Console.WriteLine("Enter how high you want to be or type 'exit' to exit");
                nCheck = Console.ReadLine();
            }

        }
    }
}
