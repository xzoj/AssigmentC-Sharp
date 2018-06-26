using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace Assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            
            while (true)
            {
                Console.WriteLine("--------Menu------");
                Console.WriteLine("1: Add a product.");
                Console.WriteLine("2: Display product.");
                Console.WriteLine("3: Delete product.");
                Console.WriteLine("4: Exit.");
                Console.WriteLine("------------------");
                Console.WriteLine("Enter your choice!");
                var choice = Int32.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        list.Add(Add());
                        break;
                    }
                    case 2:
                    {
                        Display(list);
                        break;
                    }
                    case 3:
                    {
                        Delete(list);
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Goodbye!!");
                        System.Environment.Exit(1);
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Please try again.");
                        break;
                    }
                }
            }
        }

        private static void Delete(List<Product> list)
        {
            
            Console.WriteLine("Enter Product ID to DELETE.");
            string producid = Console.ReadLine();
            var itemToRemove = list.SingleOrDefault(r => r.ProductId == producid);
            if (itemToRemove != null)
            {
                list.Remove(itemToRemove);
                Console.WriteLine("Delete done.");
            }
                            
        }

        private static void Display(List<Product> list)
        {
            Console.WriteLine("Product ID"+"    "+"Product Name"+"      "+"Price");
            Console.WriteLine("=================================================");
            foreach (var product in list)
            {
                Console.WriteLine(product.ProductId +"  "+ product.ProductName+"  "+ product.Price);
            }
        }

        private static Product Add()
        {
            Console.WriteLine("Enter product ID:");
            string productId = Console.ReadLine();
            Console.WriteLine("Enter product Name:");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter product Price:");
            int price = Console.Read();
            return new Product(productId, productName, price);
        }
    }
}