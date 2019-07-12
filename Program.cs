using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQd_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // Restricting/Filtering
            List<string> Fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in Fruits
                                          where fruit[0] == 'L'
                                          select fruit;


            List<int> Numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = Numbers.Where(number => number % 4 == 0 | number % 6 == 0);

            // Ordering Operations
            List<string> Names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            IEnumerable<string> descend = Names.OrderByDescending(name => name);

            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> AscNumbs = numbers.OrderBy(number => number);

            // Aggregate Operations
            List<int> Numbs = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var numNumbs = Numbs.Count();


            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            var total = purchases.Sum();


            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            var mostExpensive = prices.OrderByDescending(price => price).ToList();
            Console.WriteLine(mostExpensive[0]);
            // OR
            var mostExpensive2 = prices.Max();
            Console.WriteLine(mostExpensive2);


            // Partitioning Operations
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            IEnumerable<int> untilPerfectSquare = wheresSquaredo.TakeWhile(number =>
            {
                var num1 = Convert.ToInt32(Math.Sqrt(number));
                var num2 = Convert.ToInt32(Math.Sqrt(number));
                return num1 * num2 != number;
            });
        }

    }

}
