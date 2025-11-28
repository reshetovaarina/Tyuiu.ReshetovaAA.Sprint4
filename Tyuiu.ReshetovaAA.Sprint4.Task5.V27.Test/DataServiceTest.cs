using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint4.Task5.V27.Lib;

namespace Tyuiu.ReshetovaAA.Sprint4.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            int[,] arr =
            {
                { -1,  2, -3,  4,  1 },
                {  0, -2,  5, -1,  3 },
                {  6,  7, -4,  2, -2 },
                {  1, -3,  4, -5,  0 },
                {  2,  2,  1, -1, -2 }
            };

            int res = ds.Calculate(arr);

            Assert.AreEqual(10, res);
        }
    }
}