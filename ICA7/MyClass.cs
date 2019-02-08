using System;
namespace ICA7
{
    public class MyClass
    {
        public void integerSum(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }

        public void doublesDutch(int num1)
        {
            int doubles = num1 * 2;
            int average = (doubles + doubles + doubles + doubles + doubles) / 2;
            Console.WriteLine(average);
        }

        public void ranSum()
        {
            Random numRan = new Random();
            int val1 = numRan.Next(0, 100);
            int val2 = numRan.Next(0, 100);
            int sum = val1 + val2;
            Console.WriteLine(sum);
        }

        public void divbyThree(int num1, int num2, int num3)
        {
            int sum = num1 + num2 + num3;
            if (sum % 3 == 0)
            {
                Console.WriteLine("truth bruh");
            }
            else
            {
                Console.WriteLine("fake news");
            }
        }

        public void strLengthCalc(String strOne, String strTwo)
        {
            if (strOne.Length > strTwo.Length)
            {
                Console.WriteLine(strTwo);
            }
            else if (strTwo.Length > strOne.Length)
            {
                Console.WriteLine(strOne);
            }
            else
            {
                Console.WriteLine("Well Crud...");
            }
        }

        public void doubArray()
        {
            int largestNum = 0;
            int doubles[] = new int[] { 4, 25, 144, 9, 36 };
            for (int i = 0; i < 4; i++)
            {
                if (doubles[i] > largestNum)
                {
                    largestNum = doubles[i];
                }
                else
                {
                    largestNum = largestNum;
                }
            }

            Console.WriteLine(largestNum);
        }

        public void ranArray()
        {
            Random numRan = new Random();
            int nums[] = new int[50];
            for (int i = 0; i < nums.Length; i++)
            {
                int val1 = numRan.Next(0, 100);
                nums[i] = val1;
                Console.WriteLine(nums[i]);
            }
        }

        public void coolBool()
        {
            bool bOne = true;
            bool bTwo = true;

            if (bOne == bTwo)
            {
                Console.WriteLine("The bools are true");
            }
            else
            {
                Console.WriteLine("The bools are false");
            }
        }

        public void multTwoTypes()
        {
            int val1 = 1;
            double num2 = 2.53;

            double product = val1 * num2;
            Console.WriteLine(product);
        }

        public void avrArray()
        {
            int sum = 0;
            int avr = 0;
            Random numRan = new Random();
            int nums[,] = new int[5,5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int val1 = numRan.Next(0, 100);
                    nums[i][j] = val1;
                    sum = nums[i][j] + sum;
                }
            }
            avr = sum / 25;
            Console.WriteLine(avr);
        }
        public static void Main(String[] args)
        {
             
        }
    }
}
