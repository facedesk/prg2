using System;
using prg2._1_intro;
using prg2._2_oop;
using prg2._3_design_patterns;
using prg2._4_functional_programming;
using prg2._5_database_design;

using System.Collections.Generic;

namespace _0_main
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Launching main");
           //NodeTest();
           //HigherOrderTest();
//           HW.Test();
           DesignPatternsTest();
           Console.ReadKey();
        
        }
        private static void StudentPatternsTest()
        {
            /* Test!!!!!!!*/
            //test Decorator pattern


            //test Factory pattern


            //test Singleton


        }





        private static void DesignPatternsTest()
        {
            NameBank nb = new NameBank();
            nb.Name = "Yoon Junsu";
            Console.WriteLine(nb.NameUpper);
            Console.WriteLine(nb.First);  
            Console.WriteLine(nb.Last);
            nb.Name = "John Jacob Jingle-Heimer Schmidt";
            Console.WriteLine(nb.NameUpper);
            Console.WriteLine(nb.First);  
            Console.WriteLine(nb.Last);

            Factory factory = new Factory();

            Console.WriteLine(@"What consumable would you like? 
            Press 0 for coffee
            Press 1 for Grain
            Press 2 for Filters
            Press 3 for an error message
            ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Consumable c = factory.ConsumableCreator((Consumables)choice);
            Console.WriteLine(c.GetType());
            
            Consumables typeofthing = Consumables.Grain;
            ourBoolean b = ourBoolean.False;

            if(b == ourBoolean.Unknown)
            {
                Console.WriteLine("we have no idea");
            }

            Console.WriteLine(typeofthing.GetType());

            Console.WriteLine(Singleton.Instance);
            Console.WriteLine(Singleton.Instance);
            

        }
        private static void HigherOrderTest()
        {
            Select s  = new Select();
            s.run();
        }

        static void NodeTest()
        {
            Console.WriteLine("Im testing node");
            string done = "";
            
            Node<double> n0 = new Node<double>(3.50);
            n0.next = new Node<double>(5.5,n0.root);
            n0++;
            n0.next = new Node<double>(15.0,n0.root);
            n0++;
            n0 = n0.root;
            
            n0.Print();
            n0.next.Print();
            Swapper<double>.Swap(n0,n0.next);
            n0.Print();
            n0.next.Print();

            /*if(n0.next == n0.next.next)
            {
                Console.WriteLine("yay");
            }
            Node<double> n10= n0;
            if(n0==n10)
            {
                Console.WriteLine("nay");
            }


            n0[0].Print();
            n0[1].Print();
            n0[400].Print();

            Node<double> k = n0[15];
*/
            /*if(n0 == n1)
            {
                Console.WriteLine("they are equal");
            }
            else
            {
                Console.WriteLine("they are not equal");
            }*/






            Node<int> linkedList = new Node<int>(0);
            Node<int> root = linkedList;
            while(done != "y")
            {
                Console.WriteLine("Insert an integer for Linked List");
                int value = Convert.ToInt32(Console.ReadLine());
                linkedList.next = new Node<int>(value,root);
                linkedList = linkedList.next;
                Console.WriteLine("Are you done adding y/n?");
                done = Console.ReadLine().ToLower();   
            }
            linkedList.Print();
            linkedList.PrintAll();
        }
        static void CoffeeTest()
        {
            
           //MrCoffee lifesaver = new  MrCoffee();
           CoffeeMaker lifesaver = new CoffeeMaker();
           

           lifesaver.AddGrains(5.0);
           lifesaver.AddWater(12);
           lifesaver.InsertFilter();

           lifesaver.Make();
           QuickMath qm = new QuickMath(5,6);

           int x = new QuickMath(6,7).Add();

            x =QuickMaths.add(5,6);
           
                      //int k = lifesaver.AddGrains(4000000);
        }
        
        static void Hw3Test()
        {

        }
        static void test(string [] args)
        {
              Intro i = new Intro(args);
              OOP o = new OOP(args);
              Design_Patterns d = new Design_Patterns(args);
              Functional_Programming f = new Functional_Programming(args);
              Database_Design dd = new Database_Design(args);
        }
        
    }
}
