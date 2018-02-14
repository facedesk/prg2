using System;

namespace prg2._2_oop
{
    public class CoffeeMaker
    {
        //this is a method, it is a constructor
        double water_amount;
        double MAX_WATER_AMOUNT;
        double coffee_amount;
        double MAX_COFFEE_AMOUNT;
        double grains_amount;
        double MAX_GRAINS_AMOUNT;
        bool on_off;

        bool FilterIn;
        //hotplate 
        public CoffeeMaker()
        {
            water_amount = 0;
            MAX_WATER_AMOUNT = 12;
            coffee_amount = 0;
            MAX_COFFEE_AMOUNT = 12;
            grains_amount = 0;
            MAX_GRAINS_AMOUNT = 6;
            FilterIn = false;
            on_off = false;
        }
        public void AddGrains(double scoops_of_grains)
        {
            if(grains_amount + scoops_of_grains > MAX_GRAINS_AMOUNT)
            {
                throw new Exception("Put some of that back, thats too much!");
            }
            else
            {
                grains_amount = grains_amount + scoops_of_grains;
            }
           
        }

        public void InsertFilter()
        {
            if(FilterIn)
            {
                throw new Exception("Filter Already In!");
            }
            else
            {
                FilterIn= true;
            }

        }
        public void AddWater(double WaterAmountToAdd)
        {
            if(water_amount+WaterAmountToAdd > MAX_WATER_AMOUNT)
            {
                throw new Exception("Too much water!!!");
            }
            else
            {
                water_amount += WaterAmountToAdd;
            }
        }
        public virtual void MakeCoffee()
        {
            on_off=true;
            //set coffee to on
            if(water_amount==0 || grains_amount==0 || FilterIn==false)
            {
                on_off=false;
                throw new Exception("No coffee produced, insufficient materials");    
            }
            else if(water_amount+coffee_amount> MAX_COFFEE_AMOUNT)
            {
                on_off=false;
                throw new Exception("Watch out!  You're about to overflow!");
            }
            
            //check for water
            //check for grains
            //check for filter
            coffee_amount += water_amount;
            //set coffee amount to amount of water
            water_amount=0;
            //set water to 0
            grains_amount= 0;
            //set grains to 0
            FilterIn=false;
            //set Filter to off
            on_off=false;
            //set coffee to off

                
        }
        
    }
}

