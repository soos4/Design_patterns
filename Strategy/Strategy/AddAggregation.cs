using System;
using System.Collections.Generic;

namespace Strategy
{
    public class AddAggregation : Aggregation
    {
        public int GetAggregatedValue(List<int> values)
        {
            int sum = 0;

            foreach (int value in values)
            {
                sum += value;
            }

            return sum;
        }
    }
}
