using System;
using System.Collections.Generic;
using System.Linq;
using CombineLists.Data;

namespace CombineLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = new LetterContent().Content().ToList();
            var numbers = new NumberContent().Content().ToList();

            List<object> combined = new List<object>();

            // use LINQ AddRange
            combined.AddRange(letters);
            combined.AddRange(numbers);
            PrintList(combined, "AddRange()");
            combined.Clear();

            // or use the LINQ Union
            combined = combined.Union(letters).ToList();
            combined = combined.Union(numbers).ToList();
            PrintList(combined.ToList(), "Union()");
            combined.Clear();

            // or use LINQ ForEach
            letters.ForEach(x => combined.Add(x));
            numbers.ForEach(y => combined.Add(y));
            PrintList(combined, "ForEach()");
            combined.Clear();

            // or use LINQ Concat
            combined = combined.Concat(letters).ToList();
            combined = combined.Concat(numbers).ToList();
            PrintList(combined, "Concat()");
            combined.Clear();

            // or manually add each item
            for (int i = 0; i < letters.Count; i++)
            {
                combined.Add(letters[i]);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                combined.Add(numbers[i]);
            }
            PrintList(combined, "List Add() with for loop");
            combined.Clear();

            Console.ReadLine();
        }

        private static void PrintList(IEnumerable<object> list, string method)
        {
            Console.WriteLine(method);
            Console.WriteLine("====================================");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("====================================");
        }
    }
}
