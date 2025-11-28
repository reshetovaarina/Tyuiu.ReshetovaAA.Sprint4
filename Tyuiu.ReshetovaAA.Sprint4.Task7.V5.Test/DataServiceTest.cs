using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint4.Task7.V5.Lib;

namespace Tyuiu.ReshetovaAA.Sprint4.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int rows = 3;
            int columns = 3;
            string str = "246813579";

            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);

            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}