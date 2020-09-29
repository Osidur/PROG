using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add customer: 1");
            Console.WriteLine("Add product: 2");
            Console.WriteLine("Exit program: 3");
            int user_choice = Convert.ToInt32(Console.ReadLine());

            switch (user_choice)
            {
                case 1:
                    Console.WriteLine("Name:");
                    String name = Console.ReadLine();
                    Console.WriteLine("Product id:");
                    String productId = Console.ReadLine();
                    User customer = new User(name, productId);
                    break;
                case 2:
                    Console.WriteLine("Id:");
                    String id = Console.ReadLine();
                    User customer = new User(id);
                    break;
                case 3:
                    Application.Exit;
                    break;

            }
        }
    }
}
