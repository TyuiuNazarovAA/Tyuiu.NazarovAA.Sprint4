using Tyuiu.NazarovAA.Sprint4.Task0.V22.Lib;

namespace Tyuiu.NazarovAA.Sprint4.Task0.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] inputMas = { 2, 1, 4, 3, 8, 5, 9 };
            int res = ds.GetSumOddArrEl(inputMas);
            int wait = 18;

            Assert.AreEqual(wait, res);
        }
    }
}
