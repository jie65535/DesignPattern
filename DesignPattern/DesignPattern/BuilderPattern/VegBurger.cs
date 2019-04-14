using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderPattern
{
    class VegBurger : Burger
    {
        public override string Name => "Veg Burger";

        public override float Price => 25.0F;
    }
}
