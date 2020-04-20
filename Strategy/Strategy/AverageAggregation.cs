using System;
using System.Collections.Generic;

namespace Strategy
{
    public class AverageAggregation : Aggregation
    {
        public int GetAggregatedValue(List<int> values)
        {
            int sum = 0;

            foreach (int value in values)
            {
                sum += value;
            }

            int avg = 0;
            if (sum != 0)
            {
                avg = sum / values.Count;
            }

            return avg;
        }
    }
}
