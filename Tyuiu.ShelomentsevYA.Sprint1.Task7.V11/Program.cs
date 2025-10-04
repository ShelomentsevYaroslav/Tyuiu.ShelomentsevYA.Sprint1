using System;
using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.ShelomentsevYA.Sprint1.Task7.V11.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint1.Task7.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Шеломенцев Я. А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Шеломенцев Ярослав Александрович | ИСТНб-25-1                 *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите до   *");
            Console.WriteLine("* 3 знаков после запятой.                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ФОРМУЛИРОВКА ЗАДАНИЯ:                                                   *");
            Console.WriteLine("* Формула: ((Ln(sin(x)))^x / ln(1+x^2)) + (y - √|x)                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x, y);
            Console.WriteLine($"Результат формулы = {result}");

            Console.ReadLine();
        }
    }
}
