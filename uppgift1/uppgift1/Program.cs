using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine("ny kund skapad");
            while (true)
            {
                Console.WriteLine("1 för att lägga till car till kunden");
                Console.WriteLine("2 för att lägga till disk till kunden");
                Console.WriteLine("3 för att skriva ut ordar");
                Console.WriteLine("4 för att avsluta");
                try
                {
                    int user_input = Convert.ToInt32(Console.ReadLine());
                    switch (user_input)
                    {
                        case 1:
                            Car car = new Car();
                            car._productId = "Fast car";
                            customer._products.Add(car);
                            Console.WriteLine("bil tillagd");
                            break;
                        case 2:
                            Disk disk = new Disk();
                            disk._productId = "Good song";
                            customer._products.Add(disk);
                            Console.WriteLine("disk tillagd");
                            break;
                        case 3:
                            foreach (var x in customer._products)
                            {
                                Console.WriteLine(x);
                            }
                            break;
                        case 4:
                            Console.WriteLine("bybye bby!");
                            Environment.Exit(0); break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("fel typ av input");
                }
            }
        }
    }
}