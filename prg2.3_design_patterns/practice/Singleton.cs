using System;

namespace prg2._3_design_patterns
{
public class Singleton
{
   private static Singleton instance;

   private Singleton() {}

   public static Singleton Instance
   {
      get 
      {
         if (instance == null)
         {
            instance = new Singleton();
         }
         return instance;
      }
   }
}
}