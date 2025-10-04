using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.ShelomentsevYA.Sprint1.Task6.V6.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint1.Task6.V6
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Шеломенцев Ярослав Александрович | ИСТНб-25-1                 *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать все слова,    *");
            Console.WriteLine("* удалив из них первую букву.                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.DeleteFirstLetter(text));


            Console.ReadLine();
        }
    }
}