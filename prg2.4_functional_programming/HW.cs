using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace prg2._4_functional_programming
{    
    public static class HW
    {
        public static string Problem1(string sentence)
        {
            List<string> words = sentence.Split(' ').ToList();
            words = words.Where(e=>e.ToUpper() == e).ToList();
            return String.Join(" ",words);
        }
        public static List<string> Problem2()
        {
    
            string[] studentRecords = File.ReadAllLines("C:\\git\\prg2\\prg2.4_functional_programming\\roster.csv");
            studentRecords = studentRecords.Where(e=> 
            Convert.ToDouble(e.Split(',')[2]) > 2.0 && 
            Convert.ToString(DateTime.Now.Year) ==e.Split(',')[1].Trim()).ToArray();

            return studentRecords.Select(e=> e.Split(',')[0]).ToList();
        }

        public static List<int> Problem3(List<string> numbers)
        {
            numbers = numbers.Where(num=>int.TryParse(num, out int n)).ToList();
            return numbers.Select(e=>Convert.ToInt32(e)).ToList();
        }
        public static void Test()
        {
            Console.WriteLine(Problem1("Hello THIS shoulD print tHis"));
            Console.WriteLine(String.Join("\r\n",Problem2()));
            List<string> nums = new List<string>();
            nums.Add("123");
            nums.Add("onetwothree");
            nums.Add("1Two3");
            Console.WriteLine(String.Join("\r\n",Problem3(nums)));
        }
    }
}
