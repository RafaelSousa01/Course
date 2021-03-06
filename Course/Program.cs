using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> List = new List<Product>();


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char option = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (option == 'i')
                {
                    Console.Write("Custom fee: ");
                    double customfee = double.Parse(Console.ReadLine());

                    List.Add(new ImportedProduct(name, price, customfee));
                }
                else if (option == 'c')
                {
                    List.Add(new Product(name, price));

                }

                else
                {
                    Console.Write("Manufacture date (DD/MM/YYYY) ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());
                    List.Add(new UsedProduct(name, price, manufacture));
                }

                Console.WriteLine("PRICE TAGS:");

                foreach (Product product in List)
                {
                    Console.WriteLine(product.PriceTag());
                }








            }







        }
    }
}
