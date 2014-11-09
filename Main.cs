using System;

namespace Test
{
	class MainClass
	{
		static void Main (string[] args)
		{
			string msg = "Hello World";
			Console.WriteLine(msg.ToUpper());

			int x = 2012;
			Console.WriteLine(msg + " " +x.ToString());
			lessthan(print());
		}
		static void lessthan(bool simpleVar)
		{
			int x = 5000;
			bool lessThanMile = x < 5200;
			if (simpleVar) {
				Console.WriteLine("This will also print.");
			}
		}
		static bool print() {
			bool simpleVar = true;
			if (simpleVar)
				Console.WriteLine("This will print." +
					"\nThis works.");
			return simpleVar;
		}
		static int FeetToInches(int feet) {
			int inches = feet * 12;
			return inches;
		}
		static double CMtoInches(double cm) {
			double inches = cm / 2.54;
			return inches;
		}
	}
}
