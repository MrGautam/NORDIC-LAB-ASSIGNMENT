using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6Q4
{
    class OpSI
    {
        public void SI(int year, double principal, double rate=10)
        {
           
            double si;
            si = principal * rate * year / 100;
            Console.WriteLine(si);
        }
        static void Main(string[] args)
        {
            OpSI S = new OpSI();
            Console.Write("Enter The Principal Amount : ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The Number of Years : ");
            int t = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the Intrest Rate Of Interest : ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Simple Intrest is :");
            S.SI(t, p);
            Console.ReadLine();
        }
    }
}
