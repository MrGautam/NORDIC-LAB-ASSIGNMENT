using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Percentage of student :");
            int per = Convert.ToInt32(Console.ReadLine());
            if (per > 70)
            {
                Console.WriteLine("Grade A");
            }
            else if (per > 60)
            {
                Console.WriteLine("Grade B");
            }
            else if (per > 50)
            {
                Console.WriteLine("Grade C");
            }
            else if (per > 40)
            {
                Console.WriteLine("Grade D");
            }
            else if (per < 40)
            {
                Console.WriteLine("Fale");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
            Console.ReadKey();
        }
    }
}
