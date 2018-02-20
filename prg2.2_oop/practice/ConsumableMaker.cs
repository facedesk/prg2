using System;
using System.Collections.Generic;
namespace prg2._2_oop
{
    public abstract class ConsumableMaker
    {
        public Dictionary<Consumable,double> Ingredients;
        public Dictionary<Consumable,double> MaxIngredients;

        public abstract Consumable Make();

    }
}
