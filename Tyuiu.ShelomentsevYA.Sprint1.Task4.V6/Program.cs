using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.ShelomentsevYA.Sprint1.Task4.V6.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint1.Task4.V6
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