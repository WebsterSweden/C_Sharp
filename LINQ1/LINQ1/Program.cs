using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Alfa", "Bravo", "Charlie", "Delta", "Echo", "Foxtrot" };

            var linqQuery = from name in names
                            where name.Contains("a")
                            select name;

            foreach (var name in linqQuery)
            {
                Console.WriteLine(name + " ");
            }

            IList<string> stringListOne = new List<string>()
            {
                "One Tutorial",
                "Two Tutorial",
                "Three Tutorial",
                "One Assignment",
                "Two Assignment",
                "Three Assignment"
            };

            var resultList = from stringSearch in stringListOne
                             where stringSearch.Contains("Tutorial")
                             select stringSearch;

            foreach (var stringResult in resultList)
            {
                Console.WriteLine(stringResult);
            }

            Console.WriteLine("----------");

            IEnumerable<string> stringListTwo = new List<string> { "One", "Two", "Three", "Four", "Five", "Six" };
            IEnumerable<int> result = stringListTwo.Select(str => str.Length);

            foreach (var stringItem in stringListTwo)
            {
                Console.WriteLine(stringItem);
            }

            foreach (var resultItem in result)
            {
                Console.WriteLine(resultItem);
            }
        }
    }
}
