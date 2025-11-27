using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint4.Task1.V25.Lib;

namespace Tyuiu.ReshetovaAA.Sprint4.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] array = { 6, 3, 6, 4, 7, 4, 6, 5, 2, 3, 6, 3, 6, 2 };

            int res = ds.Calculate(array);
            int wait = 42;

            Assert.AreEqual(wait, res);
        }
    }
}