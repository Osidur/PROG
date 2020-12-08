using System;
using System.Collections.Generic;
using System.Text;

namespace Butik2
{
    class Cow : FourLeggedBros
    {
        public override void AnimalPoo()
        {
            Console.WriteLine("Not on the grass");
        }

        public override void AnimalRoast()
        {
            Console.WriteLine("Beaf");
        }
        public override void HaveFourLegs()
        {
            Console.WriteLine("I have four legs");
        }
    }
}
