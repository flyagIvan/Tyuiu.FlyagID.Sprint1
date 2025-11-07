using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FlyagID.Sprint1.Task7.V6.Lib
{
    public class DataService : ISprint1Task7V6
    {
        public double Calculate(double x, double y)
        {
            double z = Math.Pow(1 + 1 / Math.Pow(x, 2), x) - 12 * Math.Pow(x, 2) * y;
            return Math.Round(z, 3);
        }
    }
}