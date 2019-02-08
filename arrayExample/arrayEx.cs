using System;
namespace arrayExample
{
    public class MyClass
    {
		static void Main(string[] args)
		{
			/*string[] myCar = new string[4];
			myCar[0] = "Camaro ZR1";
			myCar[1] = "McLarne 570S";
			myCar[2] = "Plymouth Barracuda";
			myCar[3] = "Shelby Mustang";

			for (int i = 0; i < myCar.Length; i++)
			{
				Console.WriteLine(myCar[i]);
			}
			Console.ReadKey();*/

			string Input;
			Console.WriteLine("Enter a time in seconds, please use an integer or type 'exit' to quit");
			Input = Console.ReadLine();
            while(Input != "exit")
			{
				int secondsIn = 0;
				bool checkInput = int.TryParse(Input, out secondsIn);
				if(checkInput == true && secondsIn >= 0)
				{
					int days = 0;
                    int hours = 0;
                    int minutes = 0;
                    int seconds = 0;

                    int oneDayinSeconds = 86400;
                    int oneHourinSeconds = 3600;
                    int oneMinuteinSeconds = 60;

					if (secondsIn >= oneDayinSeconds)
                    {
                        days = secondsIn / oneDayinSeconds;
                        secondsIn = secondsIn % oneDayinSeconds;
                        Console.WriteLine("Days: " + days);
                    }
                    else
                    {
                        Console.WriteLine("Days: " + days);
                    }
                    if (secondsIn >= oneHourinSeconds)
                    {
                        hours = secondsIn / oneHourinSeconds;
                        secondsIn = secondsIn % oneHourinSeconds;
                        Console.WriteLine("Hours: " + hours);
                    }
                    else
                    {
                        Console.WriteLine("Hours: " + hours);
                    }
                    if (secondsIn >= oneMinuteinSeconds)
                    {
                        minutes = secondsIn / oneMinuteinSeconds;
                        secondsIn = secondsIn % oneMinuteinSeconds;
                        Console.WriteLine("Minutes: " + minutes);
                    }
                    else
                    {
                        Console.WriteLine("Minutes: " + minutes);
                    }
                    if (secondsIn < oneMinuteinSeconds)
                    {
                        seconds = secondsIn;
                        Console.WriteLine("Seconds: " + seconds);
                    }
                    else
                    {
                        Console.WriteLine("Seconds: " + seconds);
                    }
					Console.WriteLine("");
					Console.WriteLine("Enter a time in seconds, please use an integer or type 'exit' to quit");
					Input = Console.ReadLine();
				}
				else
				{
					Console.WriteLine("");
					Console.WriteLine("Enter a time in seconds, please use an integer or type 'exit' to quit");
                    Input = Console.ReadLine();
				}
			}
			/*int secondsIn = 0;
			int.TryParse(Input, out secondsIn);

			int days = 0;
			int hours = 0;
			int minutes = 0;
			int seconds = 0;

			int oneDayinSeconds = 86400;
			int oneHourinSeconds = 3600;
			int oneMinuteinSeconds = 60;

			if(secondsIn >= oneDayinSeconds)
			{
				days = secondsIn / oneDayinSeconds;
                secondsIn = secondsIn % oneDayinSeconds;
                Console.WriteLine("Days: " + days);
			}
			else
			{
				Console.WriteLine("Days: " + days);
			}
			if(secondsIn >= oneHourinSeconds)
			{
				hours = secondsIn / oneHourinSeconds;
				secondsIn = secondsIn % oneHourinSeconds;
				Console.WriteLine("Hours: " + hours);
			}
			else
            {
				Console.WriteLine("Hours: " + hours);
            }
			if(secondsIn >= oneMinuteinSeconds)
			{
				minutes = secondsIn / oneMinuteinSeconds;
                secondsIn = secondsIn % oneMinuteinSeconds;
                Console.WriteLine("Minutes: " + minutes);
			}
			else
			{
				Console.WriteLine("Minutes: " + minutes);
			}
			if(secondsIn < oneMinuteinSeconds)
			{
				seconds = secondsIn;
                Console.WriteLine("Seconds: " + seconds);
			}
			else
			{
				Console.WriteLine("Seconds: " + seconds);
			}*/
		}
    }
}
