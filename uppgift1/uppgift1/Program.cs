using System;
using System.Reflection.Metadata;

namespace uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int user_input = Convert.ToInt32(Console.ReadLine());
            switch(user_input)
            {
                case 1:
                    Customer customer = new Customer();
                    Console.WriteLine("vad heter du");
                    customer.name = Console.ReadLine();

                    Console.WriteLine("");
                    int user_input2 = Convert.ToInt32(Console.ReadLine());
                    switch (user_input2)
                    {
                        case 1:
                            Product product = new Product();
                            product.name = "car";
                            customer.products.Add(product);
                            break;
                        default:
                            Console.WriteLine("tokohej");
                            break;
            }
                    break;
                default:
                    Console.WriteLine("tokohej");
                    break;
            }
        }
    }
}
