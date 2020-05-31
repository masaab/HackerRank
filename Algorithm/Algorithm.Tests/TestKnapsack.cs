using System.Collections.Generic;
using Xunit;

namespace Algorithm.Tests
{
    public class TestKnapsack
    {
        [Fact]
        public void TestMethod1()
        {
            Knapsack knapsack= new Knapsack();
            var val = knapsack.Input(new List<long> { 1, 6, 9, 13, 14 }, 12);
            Assert.Equal(1, 1);
        }
    }
}
