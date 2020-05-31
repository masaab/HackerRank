using System.IO;
using Xunit;

namespace Algorithm.Tests
{
    public class PrefixSetTests
    {

        private string[] ReadFromTextFile(string fileName)
        {
            string[] sample = null;
            var path = Directory.GetCurrentDirectory() + $"/{fileName}";
            using (StreamReader reader = new StreamReader(path))
            {
                sample = File.ReadAllLines(path);
            }
            return sample;
        }

        [Fact]
        public void ShouldHavePrefix3()
         {
            NoPrefixSet noPrefixSet = new NoPrefixSet();
            string[] sample = { "aab", "aad", "aade", "abc", "adf", "aad", "aac", "aae", "aaf", "aedertg", "aedertt", "aad", "aae", "aaf", "aacghgh", "aabghgh" };
             var value = noPrefixSet.GenerateNodes(sample);
            Assert.Equal("aade", value);
        }

        [Fact]
        public void ShouldHavePrefix31()
        {
            NoPrefixSet noPrefixSet = new NoPrefixSet();
            string[] sample = { "ball", "bat", "be", "been" };
            var value = noPrefixSet.GenerateNodes(sample);
            Assert.Equal("been", value);
        }

        [Fact]
        public void ShouldHavePrefix6()
        {
            NoPrefixSet noPrefixSet = new NoPrefixSet();
            string[] sample = ReadFromTextFile("TextFile2.txt");
            var value = noPrefixSet.GenerateNodes(sample);
            Assert.Equal("aaaabbbbbcccccdddddeeeeefffffggggghhjhjiijiiihjhj", value);
        }

        [Fact]
        public void ShouldHavePrefix7()
        {
            NoPrefixSet noPrefixSet = new NoPrefixSet();
            string[] sample = { "aab", "bbbbbbbbbb", "defgab", "abcde", "aabcde", "cedaaa", "jabjjjad" };
            var value = noPrefixSet.GenerateNodes(sample);
            Assert.Equal("aabcde", value);
        }

        [Theory]
        [InlineData("hdgdfgfbfhccd", "h")]
        [InlineData("h", "hdgdfgfbfhccd")]
        public void ShouldHavePrefix10(string a, string b)
        {
            //Arrange
            NoPrefixSet noPrefixSet = new NoPrefixSet();
            string[] sample = { a, b };
            var value = noPrefixSet.GenerateNodes(sample);

            //Act
            Assert.Equal(b, value);
        }

        [Fact]
        public void ShouldHavePrefix11()
        {
            NoPrefixSet noPrefixSet = new NoPrefixSet();
            string[] sample =  ReadFromTextFile("TextFile1.txt");
            var value = noPrefixSet.GenerateNodes(sample);

            Assert.Equal("h", value);
        }

        [Fact]
        public void ShouldHavePrefix12()
        {
            NoPrefixSet noPrefixSet = new NoPrefixSet();
            string[] sample = { "aab", "aabcde", "abcde", "aabcde", "cedaaa", "bbbbbbbbbb", "jabjjjad" };
            var value = noPrefixSet.GenerateNodes(sample);
            Assert.Equal("aabcde", value);
        }

        [Theory]
        [InlineData("aabe", "aabcde", "aab")]
        public void ShouldHavePrefix15(string a, string b, string c)
        {
            NoPrefixSet noPrefixSet = new NoPrefixSet();
            string[] sample = { a, b, c };
            var value = noPrefixSet.GenerateNodes(sample);
            Assert.Equal(c, value);
        }

        [Theory]
        [InlineData("aabe", "aabcde", "aabed")]
        public void ShouldHavePrefix16(string a, string b, string c)
        {
            NoPrefixSet noPrefixSet = new NoPrefixSet();
            string[] sample = { a, b, c };
            var value = noPrefixSet.GenerateNodes(sample);
            Assert.Equal(c, value);
        }



        [Theory]
        [InlineData("aabe", "aabcde", "aabed","aab")]
        public void ShouldHavePrefix17(string a, string b, string c, string d)
        {
            NoPrefixSet noPrefixSet = new NoPrefixSet();
            string[] sample = { a, b, c, d};
            var value = noPrefixSet.GenerateNodes(sample);
            Assert.Equal(c, value);
        }
    }
}
