using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Q2
{
    class SI1
    {
        public void SI(int year, double principal, double rate)
        {

            double si;
            si = principal * rate * year / 100;
            Console.WriteLine(si);
        }
        static void Main(string[] args)
        {
            SI1 SI1 = new SI1();
            Console.Write("Enter The Principal Amount : ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The Number of Years : ");
            int t = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the Intrest Rate Of Interest : ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Simple Intrest is :");
            SI1.SI(t, p, r);
            Console.ReadLine();
        }
    }
}
