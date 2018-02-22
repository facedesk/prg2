using System;
using System.Collections.Generic;
namespace prg2._2_oop
{
    public class CoffeeMaker : ConsumableMaker
    {
        
        public CoffeeMaker()
        {
            Ingredients = new Dictionary<System.Type,Consumable>();
            MaxIngredients = new Dictionary<System.Type,double>();
            Ingredients[typeof(Water)]= new Water();
            Ingredients[typeof(Grain)]= new Grain();
            Ingredients[typeof(Coffee)]= new Coffee();
        }
        public void AddWater(double AmountOfWater)
        {
            Ingredients[typeof(Water)].quantity += AmountOfWater;            
        }
        public void AddGrains(double AmountOfGrains)
        {
            Ingredients[typeof(Grain)].quantity += AmountOfGrains;
        }
        public void InsertFilter()
        {
            Ingredients[typeof(PaperFilter)].quantity += 1.0;
        }
        public override Consumable Make()
        {
            throw new NotImplementedException();
        }
    }
}

