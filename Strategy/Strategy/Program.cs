using System;
using System.Collections.Generic;

namespace Strategy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Aggregator aggregator = new Aggregator(new AverageAggregation());

            List<int> data1 = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            int result = aggregator.GetAggregatedValue(data1);
            Console.WriteLine(result);

            List<int> data2 = new List<int>
            {
                1, 8, 4, 2, 16, 23, 10, 12, 28, 6
            };

            result = aggregator.GetAggregatedValue(data2);
            Console.WriteLine(result);

            List<int> data3 = new List<int>
            {
                7, 6, 4, 9, 15, 43, 6, 10, 28, 3
            };

            result = aggregator.GetAggregatedValue(data3);
            Console.WriteLine(result);
        }
    }
}