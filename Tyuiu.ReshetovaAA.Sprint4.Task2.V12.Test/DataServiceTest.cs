using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint4.Task2.V12.Lib;

namespace Tyuiu.ReshetovaAA.Sprint4.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] testArray = { 4, 5, 9, 6, 7, 8, 4, 9, 5, 6, 7, 9, 4, 5 };
            int res = ds.Calculate(testArray);

            int expected = 5 + 9 + 7 + 9 + 5 + 7 + 9 + 5; 
            Assert.AreEqual(expected, res);
        }
    }
}