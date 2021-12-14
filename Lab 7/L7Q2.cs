using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7Q2
{
    class Program
    {
        enum city { Ranchi = 834001, Bokaro = 827013, Hazaribag = 825301, Delhi = 110002, Bangalore = 560002 }
        static void Main(string[] args)
        {
            Console.WriteLine("City Name.\n");
            string[] cityName = Enum.GetNames(typeof(city));
            foreach (string i in cityName)
                Console.WriteLine(i);

            Console.WriteLine("\nPin Code of City\n");
            int[] n = (int[])Enum.GetValues(typeof(city));
            foreach (int x in n)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
