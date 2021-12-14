using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age in string : ");
            string str_age = Console.ReadLine();
            Type ty = str_age.GetType();
            Console.WriteLine("Data type of Age is " + ty);
            int int_age = int.Parse(str_age);
            Console.WriteLine("Your int value of age is " + int_age);
            Type ty1 = int_age.GetType();
            Console.WriteLine("After conver Data type of Age is " + ty1);
            Console.ReadKey();
        }
    }
}
