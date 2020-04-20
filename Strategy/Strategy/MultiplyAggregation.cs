using System;
using System.Collections.Generic;

namespace Strategy
{
    public class MultiplyAggregation : Aggregation
    {
        public int GetAggregatedValue(List<int> values)
        {
            int mul = 1;

            foreach (int value in values)
            {
                mul *= value;
            }

            return mul;
        }
    }
}
