using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderPattern
{
    class Meal
    {
        private List<IItem> _Items = new List<IItem>();

        public void AddItem(IItem item)
        {
            _Items.Add(item);
        }

        public float Cost
        {
            get
            {
                float cost = 0.0F;
                foreach (var item in _Items)
                {
                    cost += item.Price;
                }
                return cost;
            }
        }

        public void ShowItems()
        {
            foreach (var item in _Items)
                Console.WriteLine("Item : {0},\tPacking : {1},\tPrice : {2}", item.Name, item.Packing.Pack, item.Price);
        }
    }
}
