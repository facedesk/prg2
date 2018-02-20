using System;
using System.Collections.Generic;
namespace prg2._2_oop
{
    public class CoffeeMaker : ConsumableMaker
    {
        
        public CoffeeMaker()
        {
            Ingredients = new Dictionary<Consumable, double>();
            MaxIngredients = new Dictionary<Consumable,double>();
            Ingredients[new Water()]= 0;
            Ingredients[new Coffee()]=0;
            Ingredients[new Grain()]=0;


        }
        public void AddWater(double AmountOfWater)
        {
            Ingredients[new Water()] = AmountOfWater;
            Console.WriteLine(Ingredients[new Water()]);

        }
        public void AddGrains(double AmountOfGrains)
        {
            
        }
        public void InsertFilter()
        {

        }
        public override Consumable Make()
        {
            throw new NotImplementedException();
        }
    }
}

