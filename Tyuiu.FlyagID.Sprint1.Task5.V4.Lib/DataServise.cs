using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FlyagID.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int k)
        {
            // 1 час = 3600 секунд
            int h = k / 3600;
            return h;
        }
    }
}