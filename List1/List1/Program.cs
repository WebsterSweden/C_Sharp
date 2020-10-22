using System;
using System.Collections.Generic;

namespace List1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeNumbers = new List<int>();
            //Console.WriteLine(primeNumbers);
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            foreach (int primeNumber in primeNumbers)
            {
                Console.WriteLine(primeNumber);
            }

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null);

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            var bigCities = new List<string>()
            {
                "New York",
                "London",
                "Mumbai",
                "Chicago"
            };

            foreach (var bigCity in bigCities)
            {
                Console.WriteLine(bigCity);
            }
        }
    }
}
