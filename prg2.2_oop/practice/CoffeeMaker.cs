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
            Ingredients[typeof(PaperFilter)]= new PaperFilter();

            MaxIngredients[typeof(Water)] = 12.0;
            MaxIngredients[typeof(Grain)] = 1.0;
            MaxIngredients[typeof(Coffee)] = 12.0;
            MaxIngredients[typeof(PaperFilter)] = 2.0;



        }
        public void AddWater(double AmountOfWater)
        {
            if(Ingredients[typeof(Water)].Quantity + AmountOfWater > MaxIngredients[typeof(Water)])
            {
                throw new Exception("Too much water!!!");         
            }
            else
            {
                Ingredients[typeof(Water)].Quantity += AmountOfWater;
            }
        }

        public void AddGrains(double AmountOfGrains)
        {
            if(Ingredients[typeof(Grain)].Quantity + AmountOfGrains > MaxIngredients[typeof(Grain)])
            {
                throw new Exception("Too much grains!!!");         
            }
            else
            {
                Ingredients[typeof(Grain)].Quantity += AmountOfGrains;
            }
        }
        public void InsertFilter()
        {
            if(Ingredients[typeof(PaperFilter)].Quantity + 1 > MaxIngredients[typeof(PaperFilter)])
            {
                throw new Exception("Too many filters!!!");         
            }
            else
            {
                Ingredients[typeof(PaperFilter)].Quantity += 1.0;
            }
        }
        public override Consumable Make()
        {
            Ingredients[typeof(Coffee)] = new Coffee((Water)Ingredients[typeof(Water)],(Grain)Ingredients[typeof(Grain)], (PaperFilter)Ingredients[typeof(PaperFilter)]);


            Ingredients[typeof(Coffee)].Quantity = Ingredients[typeof(Water)].Quantity;
            Ingredients[typeof(Water)].Quantity = 0;
           
            return Ingredients[typeof(Coffee)];
        }
        public void Clean()
        {

        }
    }
}

