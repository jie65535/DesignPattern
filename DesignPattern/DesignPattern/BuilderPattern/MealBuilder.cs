using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderPattern
{
    class MealBuilder
    {
        /// <summary>
        /// 素类套餐：素汉堡+可口可乐
        /// </summary>
        /// <returns></returns>
        public Meal PrepareVegMeal()
        {
            Meal meal = new Meal();
            meal.AddItem(new VegBurger());
            meal.AddItem(new Coke());
            return meal;
        }

        /// <summary>
        /// 非素类套餐：鸡肉汉堡+百事可乐
        /// </summary>
        /// <returns></returns>
        public Meal PrepareNonVegMeal()
        {
            Meal meal = new Meal();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new Pepsi());
            return meal;
        }
    }
}
