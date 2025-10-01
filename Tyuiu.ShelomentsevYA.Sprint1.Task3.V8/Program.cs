using Tyuiu.ShelomentsevYA.Sprint1.Task3.V8.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint1.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

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
