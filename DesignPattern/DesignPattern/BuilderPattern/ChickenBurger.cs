using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderPattern
{
    class ChickenBurger : Burger
    {
        public override string Name => "Chicken Burger";

        public override float Price => 50.5F;
    }
}
