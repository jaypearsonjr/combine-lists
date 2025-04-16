using System;
using System.Collections.Generic;
using CombineLists.Data;

namespace CombineLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> letters = new List<string>
            {
                "a", "b", "c", "d"
            };

            List<int> numbers = new List<int>
            {
                1, 2, 3, 4
            };

            List<object> characters = new List<object>();

            for (int i = 0; i < letters.Count && i < numbers.Count; i++)
            {
                characters.Add(letters[i]);
                characters.Add(numbers[i]);
            }

            foreach (object character in characters)
            {
                Console.WriteLine(character);                
            }

            Console.ReadLine();
        }
    }
}
