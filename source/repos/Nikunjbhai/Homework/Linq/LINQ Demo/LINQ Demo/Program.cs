using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LINQ_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> names = new List<string>() { "Kim","namjoon","soakjin","taehyung"};
            var qs = names.AsEnumerable().Contains("Kim");

            List<Object> list11 = new List<Object>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,"hetal","denish"};

            var methodSyn = list11.OfType<string>().ToList();
            string a = "Hello";
            int b = 30;
            a.ToUpper();
            b.add(20);

            //1. Writing Query Syntax
            Console.WriteLine("1. Writing Query Syntax");
            var querySyntax = from obj in list
                              where obj > 2
                              select obj;
            //Execute the Query
            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("2. Writing Method Syntax");

            var methodSyntax = list.Where(obj => obj > 2);

            //Execute the Query
            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("3. Writing Mixed Syntax");

            var mixedSyntax = (from obj in list
                               select obj).Single(obj => obj == 4);

            //Console.WriteLine(mixedSyntax);
            var i = mixedSyntax.ToString();
            foreach (var item in i)
            {
                Console.WriteLine(item);
            }

           //Regex Example

            // Create a pattern for a word that starts with letter "M"
            string pattern = @"\b[m]\w+";
            // Create a Regex  
            Regex rg = new Regex(pattern, RegexOptions.IgnoreCase);

            // Long string  
            string authors = "Mahesh Chand, Raj Kumar, Mike Gold, Allen O'Neill, Marshal Troll";
            // Get all matches  
            MatchCollection matchedAuthors = rg.Matches(authors);
            // Print all matched authors  
            for (int count = 0; count < matchedAuthors.Count; count++)
                Console.WriteLine(matchedAuthors[count].Value);

            //Serialize Demo
           // SerializeDeserializeDemo st = new SerializeDeserializeDemo();
            //st.SerializeNow();
            //st.DeSerializeNow();
         
            Console.ReadLine();
        }
        
    }

   public static class ExtentionMethodClass{
        
        public static string ToUpper(this string value)
        {
            return value.ToUpper(); 
        }

        public static int add(this int value,int b)
        {
            return value + b;
        }
    }
}
