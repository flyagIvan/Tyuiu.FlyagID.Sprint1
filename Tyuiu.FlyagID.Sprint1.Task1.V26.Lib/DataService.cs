using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.FlyagID.Sprint1.Task1.V26.Lib
{
    public class DataService : ISprint1Task1V26
    {
        

        public double Calculate(double x, double y)
        {
            double result = 5 * x / (2 + y);
            return result;
        }
    }
}
