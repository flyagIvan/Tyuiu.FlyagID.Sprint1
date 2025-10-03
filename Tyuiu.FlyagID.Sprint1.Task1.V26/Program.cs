using System;
using Tyuiu.FlyagID.Sprint1.Task1.V26.Lib;


namespace Tyuiu.FlyagID.Sprint1.Task1.V26
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт 1 | выполнил: Фляг И.Д. | ИСПБ-25-1";
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Спринт №1                                                           ");
            Console.WriteLine("Тема: Базовые навыки работы в C#                                    ");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Задание №1                                                          ");
            Console.WriteLine("Вариант №26                                                          ");
            Console.WriteLine("Выполнил: Фляг Иван Дмитриевич | ИСПБ-25-1                          ");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("УСЛОВИЕ:                                                            ");
            Console.WriteLine("Написать программу которая вычисляет выражение 5*x/ (2+y)           ");
            Console.WriteLine("и печатает результат на экране.                                     ");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                   ");
            Console.WriteLine("********************************************************************");
            double x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ :                                                         ");
            Console.WriteLine("********************************************************************");


            
            Console.WriteLine(ds.Calculate(x,y));
            Console.ReadKey();
        }
    }
}