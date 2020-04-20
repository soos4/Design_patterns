using System;
using System.Collections.Generic;

namespace Strategy
{
    public interface Aggregation
    {
        int GetAggregatedValue(List<int> values);
    }
}
