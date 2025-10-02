using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.ShelomentsevYA.Sprint1.Task5.V4.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint1.Task5.V4
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
            Console.WriteLine("Введите число секунд:");
            x = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            int h = ((tyuiu.cources.programming.interfaces.Sprint1.ISprint1Task5V4)ds).SecondsToHours(x);
            Console.WriteLine("Полное количество часов: " + h);


            Console.ReadLine();
        }
    }
}