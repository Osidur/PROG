using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Sandbox
{
    class User()
    {
        public string _name;
        public int[] _productId;

        public void createUser()
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Name of user:");
		            string name = Console.ReadLine();
		            Console.WriteLine("Product id:");
                    string productId = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please write the name in letters and the product id in numbers.")
                }
            }
            User customer = new User(name, productId);
        }
    }
}
