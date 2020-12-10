using System;
using System.Collections.Generic;
using System.Text;

namespace Butik2
{
    class Pig : FourLeggedBros
    {
        public override void AnimalPoo()
        {
            Console.WriteLine("ew, yuck, and ono");
        }

        public override void AnimalRoast()
        {
            Console.WriteLine("Bacon");
        }
        public override void HaveFourLegs()
        {
            Console.WriteLine("I have four legs");
        }
    }
}
