using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6Q1
{
    class factorial
    {
        public void fact(int n)
        {
            int i, f = 1;
            for (i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.Write("Factorial of " + n + " is: " + f);
        }
        static void Main(string[] args)
        {  
            factorial factorial = new factorial();
            Console.WriteLine("Enter number to get factorial :");
            int n = int.Parse(Console.ReadLine());
            factorial.fact(n);
            Console.ReadLine();
        }
    }
}
