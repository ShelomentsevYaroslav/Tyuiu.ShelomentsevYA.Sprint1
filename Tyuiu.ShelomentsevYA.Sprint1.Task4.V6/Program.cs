using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.ShelomentsevYA.Sprint1.Task4.V6.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint1.Task4.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Шеломенцев Я. А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Class Math                                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Шеломенцев Ярослав Александрович | ИСТНб-25-1                 *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычесляет результат по формуле и печатает его на экране. Ответ          *");
            Console.WriteLine("* округлите до 3 знаков после запятой                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ФОРМУЛИРОВКА ЗАДАНИЯ:                                                   *");
            Console.WriteLine("* Формула: (|y^2-x|) / (x*y)                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");


            int x;
            Console.WriteLine("Введите число X:");
            x = Convert.ToInt32(Console.ReadLine());

            int y;
            Console.WriteLine("Введите число Y:");
            y = Convert.ToInt32(Console.ReadLine());

            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double a = ds.Calculate(x, y);
            Console.WriteLine("Результат формулы: " + a );
            Console.ReadLine();
        }
    }
}