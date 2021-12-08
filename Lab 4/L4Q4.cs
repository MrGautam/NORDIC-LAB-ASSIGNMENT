using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_4_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            while (i <= 10)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
                i++;
            }
            Console.ReadKey();
        }
    }
}
