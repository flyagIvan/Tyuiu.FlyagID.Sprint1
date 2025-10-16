using System;
using Tyuiu.FlyagID.Sprint1.Task3.V1.Lib;

namespace Tyuiu.FlyagID.Sprint1.Task3.V1
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
            Console.WriteLine("* Задание #3                                 *");
            Console.WriteLine("* Вариант #1                                 *");
            Console.WriteLine("* Выполнил: Фляг И.Д. | ИСПб-25-1           *");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* УСЛОВИЕ :                                   *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране*");

            Console.WriteLine("*Объявите необходимые переменные и напишите программу вычисления объема цилиндра, предполагающий ввод исходных данных. Ответ округлите до 3 знаков после запятой*");
            Console.WriteLine("*****************************************    *");

            Console.WriteLine("Введите радиус цилиндра:");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите высоту цилиндра:");
            double height = Convert.ToDouble(Console.ReadLine());

            double result = ds.CylinderVolume(radius, height);

            Console.WriteLine($"Объем цилиндра = {result}");
        }
    }
}
