using Komposition.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Komposition.Concretes
{
    class Cat : Animal, ICat
    {
        public void Eat()
        {
            Console.WriteLine("Cat is eating");
        }

        public void Move()
        {
            Console.WriteLine("Cat is moving");
        }
    }
}
