using Tyuiu.ShelomentsevYA.Sprint1.Task3.V8.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint1.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Шеломенцев Я. А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Шеломенцев Ярослав Александрович | ИСТНб-25-1                 *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ФОРМУЛИРОВКА ЗАДАНИЯ:                                                   *");
            Console.WriteLine("* Написать программу вычисления величины дохода по вкладу. Процентная     *");
            Console.WriteLine("* ставка (% годовых) и время хранения (дней) задаются во время работы     *");
            Console.WriteLine("* программы. Ответ округлите до 3 знаков после запятой                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            int x;
            Console.WriteLine("Введите величину вклада:");
            x = Convert.ToInt32(Console.ReadLine());

            int y;
            Console.WriteLine("Введите процент вклада:");
            y = Convert.ToInt32(Console.ReadLine());

            int z;
            Console.WriteLine("Введите срок вклада:");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double a = ds.IncomeAmount(x, y, z);
            Console.WriteLine("Доход: " + a);
            Console.WriteLine("Сумма по окончании: " + (x + a));
            Console.ReadLine();
        }
    }
}
