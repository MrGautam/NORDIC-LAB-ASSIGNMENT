using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 10, 40, 50 }, { 60, 20, 70 }, { 80, 90, 30 } };
            int r1 = 0;
            int r2 = 0;
            int r3 = 0; 
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        r1 = r1 + arr[i, j];
                    }
                    else if(i == 1)
                    {
                        r2= r2 + arr[i, j];
                    }
                    else if (i == 2)
                    {
                        r3 = r3 + arr[i, j];
                    }
                }
            }
            Console.WriteLine("Sum of Coloumn 1 is: " + r1);
            Console.WriteLine("Sum of Coloumn 2 is: " + r2);
            Console.WriteLine("Sum of Coloumn 3 is: " + r3);
            Console.ReadLine();
        }
    }
}
