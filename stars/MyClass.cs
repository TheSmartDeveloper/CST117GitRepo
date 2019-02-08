using System;
namespace stars
{
    public class MyClass
    {      
		public static void Main(string[] args)
		{
            //increment stars in each line
			int val = 7;
			for (int i = 0; i <= val; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
			Console.WriteLine("- - - - - - - - - -");
            //increment stars in each line then decrement in each line
			for (int i = 0; i <= val; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }

			for (int i = val; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
			Console.WriteLine("- - - - - - - - - -");
            //increment values
			for (int i = 0; i <= val; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if(j%2 == 0)
					{
						Console.Write("0 ");
					}
					else
					{
						Console.Write("1 ");
					}
                }
                Console.WriteLine("");
            }
            Console.WriteLine("- - - - - - - - - -");
		}
    }
}
