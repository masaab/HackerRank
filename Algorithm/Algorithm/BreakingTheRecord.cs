using System.Linq;

namespace Algorithm
{
    public class BreakingTheRecord
    {
        long highestScore = 0;
        long lowestScore = 0;

        long currentHighest = 0, currentLowest = 0;

        public long[] breakingRecords(long[] scores)
        {
            currentHighest = scores[0];
            currentLowest = scores[0];

            scores.ToList().ForEach((a) => SetResult(a));

            return new[] { highestScore, lowestScore };
        }

        private void SetResult(long currentValue)
        {
            if (currentHighest < currentValue)
            {
                currentHighest = currentValue;
                highestScore++;
            }
            else if (currentLowest > currentValue)
            {
                currentLowest = currentValue;
                lowestScore++;
            }
        }
    }
}
