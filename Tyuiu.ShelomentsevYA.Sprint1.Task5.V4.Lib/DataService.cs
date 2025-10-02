using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShelomentsevYA.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int time)
        {
            // 1 час = 3600 секунд
            return time / 3600;
        }
    }
}
