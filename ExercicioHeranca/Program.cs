using System;
using System.Globalization;
using ExercicioHeranca.Entities;
using System.Collections.Generic;

namespace ExercicioHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the numer of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported(c/u/i): ");
                char aux = char.Parse(Console.ReadLine());
                if (aux == 'c' || aux == 'C')
                {
                    Console.Write("Name: ");
                    string Name = Console.ReadLine();
                    Console.Write("Price: ");
                    double Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product Product = new Product(Name, Price);
                    list.Add(Product);
                }
                else if (aux == 'u' || aux == 'U')
                {
                    Console.Write("Name: ");
                    string Name = Console.ReadLine();
                    Console.Write("Price: ");
                    double Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date(DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    UsedProduct usedProduct = new UsedProduct(Name, Price, date);
                    list.Add(usedProduct);
                }
                else {
                    Console.Write("Name: ");
                    string Name = Console.ReadLine();
                    Console.Write("Price: ");
                    double Price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Customs fee: ");
                    double CustomsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    ImportedProduct Imported = new ImportedProduct(Name, Price, CustomsFee);
                    list.Add(Imported);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Price tags:");
            foreach ( Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}
