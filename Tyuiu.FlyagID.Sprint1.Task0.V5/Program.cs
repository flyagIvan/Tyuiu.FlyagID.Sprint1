﻿using System;
using Tyuiu.FlyagID.Sprint1.Task0.V5.Lib;


namespace Tyuiu.FlyagID.Sprint1.Task0.V5
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
            Console.WriteLine("Задание №0                                                          ");
            Console.WriteLine("Вариант №5                                                          ");
            Console.WriteLine("Выполнил: Фляг Иван Дмитриевич | ИСПБ-25-1                          ");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("УСЛОВИЕ:                                                            ");
            Console.WriteLine("Написать программу которая вычисляет выражение (1+2)*(1+9/3)        ");
            Console.WriteLine("и печатает результат на экране.                                     ");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                   ");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("(1 + 2) * (1 + 9 / 3)                                               ");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ :                                                         ");
            Console.WriteLine("********************************************************************");


            double x = (1 + 2) * (1 + 9 / 3);
            Console.WriteLine(ds.Calculate());
            Console.ReadKey();
        }
    }
}