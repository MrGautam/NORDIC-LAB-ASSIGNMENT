using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6Q2
{
    class SimpleIntrest
    {
        public void SI(int year, double principal, double rate )
        {

            double si;
            si = principal*rate*year/100;
            Console.WriteLine( si );
        }
        static void Main(string[] args)
        {

            SimpleIntrest simpleIntrest = new SimpleIntrest();
            Console.Write("Enter The Principal Amount : ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The Number of Years : ");
            int t = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the Intrest Rate Of Interest : ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Simple Intrest is :");
            simpleIntrest.SI(t, p, r);
            Console.ReadLine();
        }
    }
}
