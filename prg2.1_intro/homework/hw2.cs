using System;

namespace prg2._1_intro 
{
    public class hw2
    {
        public void run()
        {
         //write all your code here! 
         Console.Write("enter the year ");
         string stryear = Console.ReadLine();
         int year = Convert.ToInt32(stryear);
         year++;
         for(int leapYearCount = 0;leapYearCount<20;year++)
         {
             if(year%400==0)
             {
                 Console.WriteLine(year + " is a leapyear");
                 leapYearCount++;
             }
             else if(year%100==0)
             {}
             else if(year % 4==0)
             {
                Console.WriteLine(year + "is a leapyear");
                leapYearCount++;
             }
          }
        }
        public void stop()
        {
           
        }
    }
}