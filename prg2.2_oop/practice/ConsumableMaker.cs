using System.Collections.Generic;
namespace prg2._2_oop
{
    public abstract class ConsumableMaker
    {
        public Dictionary<System.Type,Consumable> Ingredients;
        public Dictionary<System.Type,double> MaxIngredients;

        public abstract Consumable Make();

    }
}
