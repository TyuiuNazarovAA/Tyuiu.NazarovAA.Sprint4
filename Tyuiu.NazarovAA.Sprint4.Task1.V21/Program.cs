using Tyuiu.NazarovAA.Sprint4.Task1.V21.Lib;

namespace Tyuiu.NazarovAA.Sprint4.Task1.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Назаров А. А. | РППб 25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Назаров Артём Александрович | СППб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 8 подсчитать произведение   *");
            Console.WriteLine("* четных элементов массива.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите длину массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] mas = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.Write($"Введите элемент {i}: ");
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(mas));
        }
    }
}
