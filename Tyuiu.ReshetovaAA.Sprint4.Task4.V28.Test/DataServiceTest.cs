using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint4.Task4.V28.Lib;

namespace Tyuiu.ReshetovaAA.Sprint4.Task4.V28.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[,]
            {
                { 3, 3, 1, 1, 4 },
                { 2, 4, 2, 1, 5 },
                { 2, 2, 2, 2, 2 },
                { 1, 5, 4, 5, 4 },
                { 1, 2, 3, 2, 4 }
            };

            int[,] expected = new int[,]
            {
                { 3, 3, 1, 1, 1 },
                { 1, 1, 1, 1, 5 },
                { 1, 1, 1, 1, 1 },
                { 1, 5, 1, 5, 1 },
                { 1, 1, 3, 1, 1 }
            };

            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}