using System;
using System.Collections.Generic;
using Komposition.Concretes;
using Komposition.Interfaces;

namespace Komposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            List<IMove> moves = new List<IMove>();

            var cat = new Cat();

            moves.Add(cat);

            foreach (var mover in moves)
            {
                mover.Move();
            }
        }
    }
}
