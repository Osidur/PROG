using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 för ny kund");
                Console.WriteLine("2 för att skriva ut ordrar");
                Console.WriteLine("3 för att avsluta");
                try
                {
                    int user_input = Convert.ToInt32(Console.ReadLine());
                    switch (user_input)
                    {
                        case 1:
                            Customer customer = new Customer();
                            Console.WriteLine("ny kund skapad");
                            Console.WriteLine("1 för att lägga till produkt till kunden");
                            Console.WriteLine("2 för att avsluta");
                            try
                            {
                                int user_input2 = Convert.ToInt32(Console.ReadLine());
                                switch (user_input2)
                                {
                                    case 1:
                                        Product product = new Product();
                                        customer.products.Add(product);
                                        Console.WriteLine("produkt tillagd");
                                        break;
                                    case 2:
                                        Console.WriteLine("bybye bby!");
                                        Environment.Exit(0);
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("fel typ av input");
                            }
                            break;
                        case 2:
                            Console.WriteLine("ordrar");
                            break;
                        case 3:
                            Console.WriteLine("bybye bby!");
                            Environment.Exit(0);
                            break;
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
