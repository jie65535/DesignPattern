using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderPattern
{
    class Coke : ColdDrink
    {
        public override string Name => "Coke";

        public override float Price => 30.0F;
    }
}
