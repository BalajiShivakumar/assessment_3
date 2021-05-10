//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace LINQEg
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            #region
//            List<int> numbers = new List<int>();
//            numbers.Add(10);
//            numbers.Add(19);
//            numbers.Add(22);
//            numbers.Add(12);
//            numbers.Add(17);
//            numbers.Add(56);
//            var answer = (from i in numbers where i > 15 select i).OrderBy(i => i).ToList();

//            var ans = numbers.Where(i => i > 15).Select(i => i).OrderByDescending(i => i);
//            foreach(var item in ans)
//            {
//                Console.WriteLine(item);
//            }
//            #endregion

//            List<string> fruits = new List<string>();
//            fruits.Add("Apple");
//            fruits.Add("Banana");
//            fruits.Add("Apricot");
//            fruits.Add("Kiwi");
//            fruits.Add("Avacodo");

//            //Query syntax of LINQ
//          //  var result = (from s in fruits where s.Length < 6 && s.StartsWith('A')  select s).ToList();

//            //Method Syntax of LINQ
//            var res = fruits.Where(s => s.StartsWith('A')).Select(s => s);

//            //var result = (from s in numbers where s % 2 == 0 select s).ToList();
//            foreach (var item in res)
//            {
//                Console.WriteLine(item);
//            }



//        }
//    }
//}
