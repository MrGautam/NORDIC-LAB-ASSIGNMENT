using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 10, 40, 50 }, { 60, 20, 70 }, { 80, 90, 30 } };
            int sum = 0;
            for(int i=0; i<arr.GetLength(0); i++)
            {
                for(int j=0; j<arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum = sum + arr[i, j];
                    }
                }
            }
            Console.WriteLine("Sum of Digonal elements are: "+sum);
            Console.ReadLine(); 
        }
    }
}
