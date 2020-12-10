using System;
using System.Collections.Generic;
using System.Text;

namespace Butik2
{
    abstract class Animal
    {
        public abstract void AnimalPoo();
        public abstract void AnimalRoast();
        public int Fast { get; set; }
        public int Slow { get; set; }
    }
}
