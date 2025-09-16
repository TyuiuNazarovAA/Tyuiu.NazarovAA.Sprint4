using Tyuiu.NazarovAA.Sprint4.Task6.V17.Lib;

namespace Tyuiu.NazarovAA.Sprint4.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            string[] strings = { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };

            int res = ds.Calculate(strings);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
