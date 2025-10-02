using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShelomentsevYA.Sprint1.Task4.V6.Lib
{
    public class DataService : ISprint1Task4V6
    {

        public double Calculate(double x, double y)
        {
            double z = (Math.Abs(Math.Pow(y, 2) - x)) / (x * y);
            return Math.Round(z, 3, MidpointRounding.AwayFromZero);
        }
    }
}
