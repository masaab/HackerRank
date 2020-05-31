//https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
using Xunit;

namespace Algorithm.Tests
{
    
    public class BreakingTheRecordTest
    {
        private BreakingTheRecord BreakingTheRecord { get; }
        public BreakingTheRecordTest()
        {
            BreakingTheRecord = new BreakingTheRecord();
        }
        [Fact]
        public void Test1()
        {
            var result = BreakingTheRecord.breakingRecords(new long[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 });
            Assert.Equal(2, result[0]);
            Assert.Equal(4, result[1]);
        }

        [Fact]
        public void Test2()
        {
            var result = BreakingTheRecord.breakingRecords(new long[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 });
            Assert.Equal(4, result[0]);
            Assert.Equal(0, result[1]);
        }
    }
}
