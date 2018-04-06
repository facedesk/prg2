using System;
using System.Collections.Generic;
using System.Linq;

namespace prg2._4_functional_programming
{    
    public class Select
    {
        public int average(List<int> a)
        {
            /*
            add them all up
            divide by number of added
            */

            /*loop through list
            if num > 0 
                include in count
                add to sum
            divide sum/count
             */

            
            a = a.Where(num => num >= 0).ToList();
            return a.Sum()/a.Count;
        }
       public void run()
       {
            List<string> words = new List<string>();
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();
            words = sentence.Split( new char[]{' '}).ToList();
            
            foreach(string word in words)
            {
                Console.Write(word+" ");
            }
            List<string> changedWords = words.Select(word => 
            word.ToLower() == "programming2" ? "Programming2 is awesome" : word )
            .ToList();
            List<string> upperWords = words.Select(MakeUpperCase).ToList();
            List<int> nums = new List<int>(3);
            List<int> nums2 = nums.Select(make10).ToList();
             
            List<string> approvedWords = changedWords.Where(word => 
            !word.ToLower().Contains("cheeto"))
            .ToList();

            List<string> combinedWords = words.Zip(changedWords,(word1,word2)=>
            word1+":"+word2).ToList();
            
          
            Console.WriteLine();
            foreach(string word in approvedWords)
            {
                Console.Write(word + " ");
            }




            DoSomething(Something);
            DoSomething(MakeUpperCase);
          //  DoTwoThings(Something,MakerUpperCase);
       }
       public string Something(string msg)
       {
           return "help me obi won kanobi " + msg;
       }
       public void DoTwoThings(Func<string,string> a, Func<string,string> b)
       {
         //  a();
         //  b();
           
       }
       public int make10(int input)
       {
           return 10;
       }
       public string MakeUpperCase(string msg)
       {
           return msg.ToUpper();
       }
        public void DoSomething(Func<string,string> anything)
        {
            Console.WriteLine(anything(Console.ReadLine()));

            anything(anything("okay"));
        }
        
    }
    
}