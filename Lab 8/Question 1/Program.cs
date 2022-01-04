using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Computer comp = new Computer();
            comp.BootUp();
            comp.ShutDown();
            Console.ReadLine();
        }
    }


    public abstract class Computer
    {
        public void BootUp()
        {
            Console.WriteLine( "System is Booting");
        }
        public void ShutDown()
        {
            Console.WriteLine("System is Shuting Down");
        }
    }

    class SuperComputer : Computer
    {
        public static void Computer()
        {
            Console.Write("Pres 1 TO BOOT AND 2 TO ShutDown. Enter Your Choice - ");
            int n = Convert.ToInt32(Console.ReadLine());
            SuperComputer ob = new SuperComputer();
            if (n == 1)
                ob.BootUp();
            else if (n == 2)
                ob.ShutDown();
            Console.ReadLine();
        }
    }

    class MainframeComputer : Computer
    {
        static void Main()
        {
            Console.Write("Pres 1 TO BOOT AND 2 TO ShutDown. Enter Your Choice - ");
            int n = Convert.ToInt32(Console.ReadLine());
            MainframeComputer ob = new MainframeComputer();
            if (n == 1)
                ob.BootUp();
            else if (n == 2)
                ob.ShutDown();
            Console.ReadLine();
        }
    }

    class MicroComputer : Computer
    {
        static void Main()
        {
            Console.Write("Pres 1 TO BOOT AND 2 TO ShutDown. Enter Your Choice -  ");
            int n = Convert.ToInt32(Console.ReadLine());
            MicroComputer ob = new MicroComputer();
            if (n == 1)
                ob.BootUp();
            else if (n == 2)
                ob.ShutDown();
            Console.ReadLine();
        }
    }


}
