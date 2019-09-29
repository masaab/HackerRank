using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class Knapsack
    {
        public long Input(List<long> arr, long input)
        {
            arr.Sort();
            var median = arr.Count;
            var item = arr.Where(a => a >= input).FirstOrDefault(); 
            arr.IndexOf(item);
            return 1;
        }
    }
}
