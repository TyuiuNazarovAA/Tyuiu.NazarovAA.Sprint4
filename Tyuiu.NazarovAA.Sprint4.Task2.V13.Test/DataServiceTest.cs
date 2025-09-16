
using Tyuiu.NazarovAA.Sprint4.Task2.V13.Lib;

namespace Tyuiu.NazarovAA.Sprint4.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] inputMas = { 2, 4, 5, 6 };
            int res = ds.Calculate(inputMas);
            int wait = 48;
            Assert.AreEqual(wait, res);
        }
    }
}
