using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NazarovAA.Sprint4.Task6.V17.Lib
{
    public class DataService : ISprint4Task6V17
    {
        public int Calculate(string[] array)
        {
            return array.Count(x => x.Length == 6);
        }
    }
}
