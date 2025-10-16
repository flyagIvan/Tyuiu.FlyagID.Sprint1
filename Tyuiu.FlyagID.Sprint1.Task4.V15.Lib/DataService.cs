using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FlyagID.Sprint1.Task4.V15.Lib
{
    public class DataService : ISprint1Task4V15
    {
        public double Calculate(double x, double y)
        {
            return (x + Math.Pow(y, 2)) / Math.Exp(2 - 4 * y);
        }
    }
}

