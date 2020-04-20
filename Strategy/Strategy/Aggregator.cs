using System;
using System.Collections.Generic;

namespace Strategy
{
    public class Aggregator
    {
        Aggregation aggregationMethod;

        public Aggregator(Aggregation aggregationMethod)
        {
            this.aggregationMethod = aggregationMethod;
        }

        public void SetAggregationMethod(Aggregation aggregationMethod)
        {
            this.aggregationMethod = aggregationMethod;
        }

        public int GetAggregatedValue(List<int> values)
        {
            return aggregationMethod.GetAggregatedValue(values);
        }
    }
}
