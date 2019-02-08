using System;
namespace calculatorcomplete
{
	public class MyClass
	{
		static void Main(string[] args)
		{
			Console.Out.WriteLine("Welcome to the calculizer 5000");

			int number1, number2;   //variables created for each number
			int result;             //variables created for the result value
			char operation;         //variable for the operation created as a char variable because each symbol is just one character

			Console.Out.Write("What is the first value? Please use whole numbers: ");   //ask user for first value
			number1 = Convert.ToInt32(Console.ReadLine());         

			Console.Out.Write("What is the operation? Please use +,-,*,/: ");   //ask user for operation, I decided to do the operation before the second value to keep it natural to a user. So it would be like entering "2" "+" "2" instead of "2" "2" "+"
            operation = Convert.ToChar(Console.ReadLine());

			Console.Out.Write("What is the second value? Please use whole numbers: ");
			number2 = Convert.ToInt32(Console.ReadLine());

			do
			{
				switch (operation)
				{
					case '+':
						result = number1 + number2;
						break;
					case '-':
						result = number1 - number2;
						break;
					case '*':
						result = number1 * number2;
						break;
					case '/':
						result = number1 / number2;
						break;
					default:
						result = 0;
						break;
				}
			}
			while
			(
					operation != '+' && operation != '-' && operation != '*' && operation != '/'
			);

			Console.WriteLine(number1.ToString() + operation + number2.ToString() + " = " + result.ToString());
			Console.ReadKey();
		}
	}
}
