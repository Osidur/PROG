using System;
using System.Reflection.Metadata;

namespace uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 för ny kund");
            int user_input = Convert.ToInt32(Console.ReadLine());
            switch(user_input)
            {
                case 1:
                    Customer customer = new Customer();
                    Console.WriteLine("ny kund skapad");

                    Console.WriteLine("1 för att lägga till produkt till kunden");
                    int user_input2 = Convert.ToInt32(Console.ReadLine());
                    switch (user_input2)
                    {
                        case 1:
                            Product product = new Product();
                            customer.products.Add(product);
                            Console.WriteLine("produkt tillagd");
                            break;
                        default:
                            Console.WriteLine("program avslutas");
                            break;
            }
                    break;
                default:
                    Console.WriteLine("program avslutas");
                    break;
            }
        }
    }
}
