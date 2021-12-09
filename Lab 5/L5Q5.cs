using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product prod1 = new Product()
            {
                ProductCode = 01,
                ProductName = "KitKat",
                Category = "Chocolate"
            };
            Product prod2 = new Product()
            {
                ProductCode = 02,
                ProductName = "Dary Milk",
                Category = "Chocolate"
            };
            Product prod3 = new Product()
            {
                ProductCode = 03,
                ProductName = "Apple",
                Category = "Fruit"
            };
            Product prod4 = new Product()
            {
                ProductCode = 04,
                ProductName = "Orange",
                Category = "Fruit"
            };
            Product prod5 = new Product()
            {
                ProductCode = 05,
                ProductName = "Patato",
                Category = "Vegetable"
            };

            List<Product> prod = new List<Product>();
            prod.Add(prod1);
            prod.Add(prod2);
            prod.Add(prod3);
            prod.Add(prod4);
            prod.Add(prod5);

            foreach (Product i in prod)
            {
                Console.WriteLine($"ProductCode: {i.ProductCode} ProductName: {i.ProductName}, Category: {i.Category}");
            }
            Console.ReadKey();
        }
    }
}
