using System;
using Tyuiu.FlyagID.Sprint1.Task4.V15.Lib;

namespace Tyuiu.FlyagID.Sprint1.Task4.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = ("Спринт #1 | Выполнил: Фляг И.Д. | ИСПб-25-1   ");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* Спринт #1                                                 *");
            Console.WriteLine("* Тема: Операторы составного присваивания                   *");
            Console.WriteLine("* Задание #4                                 *");
            Console.WriteLine("* Вариант #15                                 *");
            Console.WriteLine("* Выполнил: Фляг И.Д. | ИСПб-25-1           *");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* УСЛОВИЕ :                                   *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле и печатает его на экране. Ответ округлите до 3 знаков после запятой.*");


            
            Console.WriteLine("*****************************************    *");
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double result = ds.Calculate(x, y);
            Console.WriteLine("Результат: " + Math.Round(result, 3));
        }
    }
}