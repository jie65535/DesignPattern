using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderPattern
{
    class Pepsi : ColdDrink
    {
        public override string Name => "Pepsi";

        public override float Price => 35.0F;
    }
}
