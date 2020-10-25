using System;
using System.Collections;
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

            List<string> listOnes = new List<string>() { "stringOne", "stringTwo", "stringThree" };
            foreach (string listOne in listOnes) { Console.WriteLine(listOne); }
            Console.WriteLine(listOnes.Count);

            Console.WriteLine("----------");

            List<string> listStringOnes = new List<string>();
            listStringOnes.Insert(0, "Zero");
            listStringOnes.Insert(1, "One");
            listStringOnes.Insert(2, "Two");

            foreach (string listStringOne in listStringOnes)
            {
                Console.WriteLine("" + listStringOne);
            }

            for (int i = 0; i < listStringOnes.Count; i++)
            {
                Console.WriteLine(listStringOnes[i]);
            }

            List<object> listObjectOnes = new List<object>();
            listObjectOnes.Add("String");
            listObjectOnes.Add(3);
            listObjectOnes.Add(0.9);

            foreach (object listObjectOne in listObjectOnes)
            {
                Console.WriteLine(listObjectOne);
            }

            ArrayList arrayListOnes = new ArrayList();
            arrayListOnes.Add("String");
            arrayListOnes.Add(3);
            arrayListOnes.Add(0.9);

            foreach (var arrayListOne in arrayListOnes)
            {
                Console.WriteLine(arrayListOne);
            }

        }
    }
}
