using Tyuiu.ReshetovaAA.Sprint4.Task6.V27.Lib;

namespace Tyuiu.ReshetovaAA.Sprint4.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            string[] arr =
            {
                "Квадрат", "Прямоугольник", "Круг", "Треугольник",
                "Пятиугольник", "Шестиугольник", "Восьмиугольник"
            };

            int res = ds.Calculate(arr);

            Assert.AreEqual(1, res);
        }
    }
}