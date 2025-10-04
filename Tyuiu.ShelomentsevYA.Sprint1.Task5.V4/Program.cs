using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.ShelomentsevYA.Sprint1.Task5.V4.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint1.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Шеломенцев Я. А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Шеломенцев Ярослав Александрович | ИСТНб-25-1                 *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Идёт k-я секунда суток. Определить, сколько полный часов (h) прошло к   *");
            Console.WriteLine("* этому моменту (например h = 3, если k = 13257).                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            int x;
            Console.WriteLine("Введите число секунд:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            int h = ds.SecondsToHours(x);
            Console.WriteLine("Полное количество часов: " + h);


            Console.ReadLine();
        }
    }
}