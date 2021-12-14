using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7Q1
{
    public struct student
    {
        private int roll;
        private string name;
        private string gen;
        private double mob;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Roll
        {
            get { return this.roll; }
            set { this.roll = value; }
        }

        public string Gender
        {
            get { return this.gen; }
            set { this.gen = value; }
        }

        public double Mob
        {
            get { return this.mob; }
            set { this.mob = value; }
        }

        public student(int roll1, string name1, string gen1, int mob1)
        {
            this.roll = roll1;
            this.name = name1;
            this.gen = gen1;
            this.mob = mob1;
        }

        public void printDetails()
        {
            Console.WriteLine("\nStudent Details\n");
            Console.WriteLine(".....................................\n");
            Console.WriteLine($"Roll No    : {this.roll}");
            Console.WriteLine($"Name       : {this.name}");
            Console.WriteLine($"Gender     : {this.gen}");
            Console.WriteLine($"Mobile No  : {this.mob}");
        }
    }
    public class Program
    {
        public static void Main()
        {
            student s = new student();
            Console.Write("Enter the Roll no : ");
            s.Roll = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Name : ");
            s.Name = (Console.ReadLine());
            Console.Write("Enter the Gender : ");
            s.Gender = (Console.ReadLine());
            Console.Write("Enter the Mobile no : ");
            s.Mob = Convert.ToDouble(Console.ReadLine());
            s.printDetails();
            Console.ReadLine();

        }
    }
}
