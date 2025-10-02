using tyuiu.cources.programming.interfaces.Sprint1;
using System;

namespace Tyuiu.ShelomentsevYA.Sprint1.Task7.V11.Lib
{
    public class DataService : ISprint1Task7V11
    {
        public double Calculate(double x, double y)
        {
            
            double numerator = Math.Pow(Math.Log(Math.Sin(x)), x);
            double denominator = Math.Log(1 + x * x);
            double part1 = numerator / denominator;

            double part2 = y - Math.Sqrt(Math.Abs(x));

            double z = part1 + part2;

            
            return Math.Round(z, 3, MidpointRounding.AwayFromZero);
        }
    }
}
