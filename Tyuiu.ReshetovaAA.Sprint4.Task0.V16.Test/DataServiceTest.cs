using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint4.Task0.V16.Lib;

namespace Tyuiu.ReshetovaAA.Sprint4.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            int res = ds.GetMultEvenArrEl(numsArray);

            int wait = 3072;

            Assert.AreEqual(wait, res);
        }
    }
}
