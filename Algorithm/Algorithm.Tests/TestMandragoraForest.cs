using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace Algorithm.Tests
{
    public class TestMandragoraForest
    {
        [FactAttribute]
        public void TestMethod()
        {
            MandragoraForest v = new MandragoraForest();
            var result = v.PerformBattle(new List<long> {2, 3, 5 });
        Assert.Equal(16, result);
        }

        [FactAttribute]
        public void TestMethod1()
        {
            MandragoraForest v = new MandragoraForest();
            var result = v.PerformBattle(new List<long> { 3, 2, 2 });
            Assert.Equal(10, result);
        }

        [FactAttribute]
        public void TestMethod2()
        {
            MandragoraForest v = new MandragoraForest();
            var result = v.PerformBattle(new List<long> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });
            Assert.Equal(315, result);
        }

        [FactAttribute]
        public void TestMethod3()
        {
            MandragoraForest v = new MandragoraForest();
            var result = v.PerformBattle(new List<long> { 8,10,14,16 });
            Assert.Equal(90, result);
        }

        [FactAttribute]
        public void TestMethod5()
        {
            MandragoraForest v = new MandragoraForest();
            var result = v.PerformBattle(new List<long> { 1, 2, 3, 4, 5 });
            Assert.Equal(36, result);
        }

        [FactAttribute]
        public void TestMethod6()
        {
            MandragoraForest v = new MandragoraForest();
            var result = v.PerformBattle(new List<long> { 1, 2, 3, 4, 5, 6, 7 });
            Assert.Equal(90, result);
        }

        [FactAttribute]
        public void TestMethod7()
        {
            MandragoraForest v = new MandragoraForest();
            var result = v.PerformBattle(new List<long> { 5, 2, 6, 11, 29, 12, 7 });
            Assert.Equal(260, result);
        }

        [FactAttribute]
        public void TestMethod8()
        {
            MandragoraForest v = new MandragoraForest();
            var result = v.PerformBattle(new List<long> { 1188729, 1052940, 9159214 ,1041177, 1109408, 1127712, 708150, 1358977, 769261, 990618, 8711306, 656084, 156949, 1188775, 9153873, 9345902 });
            Assert.Equal(472813835, result);
        }

        [FactAttribute]
        public void TestMethod9()
        {
            MandragoraForest v = new MandragoraForest();
            var result = v.PerformBattle(new List<long> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });
            Assert.Equal(910, result);
        }



        [FactAttribute]
        public void TestMethod11()
        {
            MandragoraForest v = new MandragoraForest();
            var result = v.PerformBattle(new List<long> { 15 });
            Assert.Equal(15, result);
        }

        [FactAttribute]
        public void TestMethod12()
        {
            MandragoraForest v = new MandragoraForest();
            List<long> ans = new List<long> { 9760016801005104
                                             ,17892186985803078
                                             ,21283224332673534
                                             ,1683437692431285
                                             ,11178130309362059
                                             ,4640365339838768
                                             ,1003209519577451
                                             ,1770678697572330
                                             ,19095990491536572
                                             ,20317044435296775};

            var path = Directory.GetCurrentDirectory()+"/input04.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                int i = 0;
                while (reader.Peek() >= 0) 
               {
                    string dataRow = Convert.ToString(reader.ReadLine());
                    var longList = dataRow.Split(" ").Select(a => Convert.ToInt64(a)).ToList();
                    var result = v.PerformBattle(longList);
                    Assert.Equal(ans[i], result);
                    i++;
                }
            }
        }

        [Fact]
        public void TestFindMedian()
        {
            MandragoraForest v = new MandragoraForest();
            var result = v.FindMedian(15);
            Assert.Equal(7, result);
        }
        
    }

}
