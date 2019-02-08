using System;

namespace arrayTest
{
	class arrayTest
	{
		public static void Main(string[] args)
		{
			int[] values = new int[] {3,19,4,2,15,14,19,6,1,11,4,2,17,12,9,20,17,3,6,14};
			var lowVals = from v in values where v < 10 select v;
			Console.WriteLine("Values < 10");
			foreach(var s in lowVals)
			{
				Console.Write(s);
				Console.Write(", ");
			}
		}
	}
}