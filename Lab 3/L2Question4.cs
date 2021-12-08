using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2.Question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            var result = num > 0 ? "Number is Positive" : "Number is Negative";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
