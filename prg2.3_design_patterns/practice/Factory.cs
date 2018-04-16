using System;
using prg2._2_oop;


namespace prg2._3_design_patterns
{
public class Factory
{
    public Consumable ConsumableCreator(Consumables id)
    {
        
        switch(id)
        {
            case Consumables.Coffee: return new Coffee();
            case Consumables.Grain: return new Grain();
            case Consumables.PaperFilter: return new PaperFilter();
            default: throw new InvalidOperationException();
        }
    }
}
}