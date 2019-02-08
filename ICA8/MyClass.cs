/*
    Kevin George
    Prof. Gordon
    CST - 117
    11 - 01 - 18
*/
using System;
namespace ICA8
{
    public class MyClass
    {
        public int fatCalories(int fg)      //method to calculate fat calories. takes in an integer argument and returns an integer.
        {
            int CalFromFat = fg * 9;
            return CalFromFat;
        }

        public int carbCalories(int cg)     //method to calculate carb calories. takes in an integer argument and returns an integer.
        {
            int CalFromCarbs = cg * 4;
            return CalFromCarbs;
        }

        public static void Main(String[] args)
        {
            int fatCalcVal = 0;
            int CarbCalcVal = 0;
            MyClass personA = new MyClass();        //class created in main to call the methods

            Console.WriteLine("Enter the grams of fat that you have consumed");     
            String fatInput = Console.ReadLine();
            bool result = int.TryParse(fatInput, out fatCalcVal);       //      if the input is an integer then it will be input into the integer variable
            Console.WriteLine(personA.fatCalories(fatCalcVal));       //#prinitbro

            Console.WriteLine("Enter the grams of carbs that you have consumed");
            String carbCalories = Console.ReadLine();
            result = int.TryParse(carbCalories, out CarbCalcVal);       //      if the input is an integer then it will be input into the integer variable
            Console.WriteLine(personA.carbCalories(CarbCalcVal));       //#prinitbro
        }
    }
}
