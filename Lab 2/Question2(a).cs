using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the char : ");
            char value = Convert.ToChar(Console.ReadLine());
            Console.WriteLine((int)value);
            Console.ReadKey();
        }
    }
}
