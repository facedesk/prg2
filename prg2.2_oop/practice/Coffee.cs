using System;

namespace prg2._2_oop
{
    public class Coffee : Consumable
    {
        public double Caffiene;

        public string RoastLevel;

        public Coffee()
        {
            Quantity=0;
            Caffiene = 0;
            RoastLevel="Non existant";
        }
        public Coffee(Water w,Grain g ,PaperFilter pf)
        {
            this.RoastLevel = g.RoastLevel;
            this.Caffiene = w.Quantity/g.Quantity;
        }
    }
}