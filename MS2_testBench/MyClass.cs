using System;
using System.IO;
namespace MS2_testBench
{
    public class MyClass
    {
        public MyClass()
        {
			
        }
		public static void Main(string[] args)
		{
			//string uName = "admin";
			//string pWord = "root";

			//string uNameCheck = "0";
			//string pWordCheck = "0";

			//uNameCheck = Console.ReadLine();
			//pWordCheck = Console.ReadLine();
			//if(uNameCheck == uName && pWordCheck == pWord)
			//{
			//	Console.WriteLine("Login Success");
			//}
			//else
			//{
			//	Console.WriteLine("Login Failure");
			//}

			string test = System.IO.File.ReadAllText(@"/home/kevin/Kevin/school/CST117/workspace/ICA6/inventory.txt");
			Console.WriteLine(test);
			string newCar = "Chevrolet Corvette";
			System.IO.File.AppendAllText(@"/home/kevin/Kevin/school/CST117/workspace/ICA6/inventory.txt", newCar);
			test = System.IO.File.ReadAllText(@"/home/kevin/Kevin/school/CST117/workspace/ICA6/inventory.txt");
            Console.WriteLine(test);
		}
    }
}
