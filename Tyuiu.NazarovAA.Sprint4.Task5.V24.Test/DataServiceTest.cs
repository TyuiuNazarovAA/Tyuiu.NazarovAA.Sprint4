using Tyuiu.NazarovAA.Sprint4.Task5.V24.Lib;

namespace Tyuiu.NazarovAA.Sprint4.Task5.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] inputMas =
            {
                { 2, 2, 5, 5, -9 },
                { 7, -3, 8, 8, 9 },
                { 6, 7, 9, -3, 5 },
                { -7, 5, 7, 7, 8 },
                { 2, 2, -4, 7, 9 },
            };

            DataService ds = new DataService();
            int res = ds.Calculate(inputMas);
            int wait = 20;
            Assert.AreEqual(wait, res);
        }
    }
}
