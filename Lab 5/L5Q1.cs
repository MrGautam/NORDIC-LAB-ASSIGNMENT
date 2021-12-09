using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[10];
            int sum = 0;
            Console.WriteLine("Enter elements in array");
            for(int i= 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            for(int i=0;i< arr.Length; i++)
            {
                sum = sum + Convert.ToInt32(arr[i]);
            }
            Console.WriteLine("Sum of array elements is: "+sum);
            Console.ReadLine();
        }
    }
}
