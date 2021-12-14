using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6Q5
{
	public class Program
	{
		public static void Main()
		{
			//Console.WriteLine("Enter principal amount, Rate of intrest and Time: ");

			try
			{
				double si;
				Console.WriteLine("Enter Principal Amount: ");
				double principal = double.Parse(Console.ReadLine());
				Console.WriteLine("Enter Rate of Intrest");
				double rate = double.Parse(Console.ReadLine());
				Console.WriteLine("Enter time duration in years");
				int year = int.Parse(Console.ReadLine());
				si = principal * rate * year / 100;
				Console.WriteLine("Simple Intrest for following data is : ");
				Console.WriteLine(si);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error occurred: {0}", ex.Message);
			}
			Console.ReadLine();
		}
	}
}
