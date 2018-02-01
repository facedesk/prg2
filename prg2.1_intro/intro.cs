using System;
using System.Linq;
using System.Collections.Generic;

namespace prg2._1_intro
{
    public class Intro
    {
        public Intro(string[] args)
        {
            Console.WriteLine("Launched intro");
            List<string> students = new List<string>();
            
            students.Add("Slosar");
            students.Add("Engel");
            students.Add("Yoon");
            students.Add("Gallagher");

            foreach(string student in students)
            {
                Console.Write(student + " ");
            }
            Console.WriteLine();            

            while(students.Count !=10)
            {
                students.Add("empty spot");
            }
        
        /* 
            string answer = Console.ReadLine();

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x + y;

            string zs =(x + y).ToString();
            Console.WriteLine(zs);
            double v = 5.0;
            Console.WriteLine(v);
            bool xIsEqualToY = x == y;

            if(x % 2 ==0)
            {
                Console.WriteLine("divisible by 2");
            }
            else if(x % 3 ==0)
            {
                Console.WriteLine("divisible by 3");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        */
        } 
    }
}
