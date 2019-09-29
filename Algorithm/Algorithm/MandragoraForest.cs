using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class MandragoraForest
    {
        public long PerformBattle(List<long> items)
        {
            items.Sort();

            var median = FindMedian(items.Count);
            var totalSum = items.Skip(median).Sum();
            long actualValue = 0;

            for (int i = median, s = median + 1; i < items.Count; i++, s++)
            {
                var nextValue = GetNextValue(s, totalSum);

                if (actualValue > nextValue)
                    return actualValue;

                actualValue = nextValue;
                totalSum -= items[i];
            }
            return actualValue;
        }

        private long GetNextValue(int s, long sumTotal)
            => sumTotal * (s);

        public int FindMedian(int countTotal)
            => countTotal / 2;
        
    }
}
