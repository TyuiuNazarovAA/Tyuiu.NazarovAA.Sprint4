using Tyuiu.NazarovAA.Sprint4.Task6.V17.Lib;

namespace Tyuiu.NazarovAA.Sprint4.Task6.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Назаров А. А. | РППб 25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Назаров Артём Александрович | СППб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Python\", \"JavaScript\", \"Java\",            *");
            Console.WriteLine("* \"C#\", \"Swift\", \"Kotlin\", \"Ruby\"] используя класс Array                  *");
            Console.WriteLine("* подсчитайте количество элементов, длина которых равна 6.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            string[] strings = { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };

            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write(strings[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(strings));
        }
    }
}
