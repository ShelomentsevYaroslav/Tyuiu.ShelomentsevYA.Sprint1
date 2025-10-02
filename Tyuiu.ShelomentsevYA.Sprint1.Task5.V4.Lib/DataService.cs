using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShelomentsevYA.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {

        int ISprint1Task5V4.SecondsToHours(int time)
        {
            return time / 3600;
        }
    }
}
