using System;
using Tyuiu.FlyagID.Sprint1.Task7.V6.Lib;

namespace Tyuiu.FlyagID.Sprint1.Task7.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Фляг И.Д. | ИСПб-25-1";
            Console.WriteLine("**");
            Console.WriteLine("* Спринт #1                                                ");
            Console.WriteLine(" Тема: Арифметические выражения                           ");
            Console.WriteLine(" Задание #7                                               ");
            Console.WriteLine(" Вариант #6                                               ");
            Console.WriteLine(" Выполнил: Фляг И.Д. | ИСПб-25-1                          ");
            Console.WriteLine("**");
            Console.WriteLine(" УСЛОВИЕ:                                                 ");
            Console.WriteLine(" Вычислить выражение:                                     ");
            Console.WriteLine(" z = (1 + 1/x^2)^x - 12x^2y                               ");
            Console.WriteLine(" Ввести значения x и y с клавиатуры.                      ");
            Console.WriteLine(" Ответ округлить до 3 знаков после запятой.               *");
            Console.WriteLine("**");
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = ds.Calculate(x, y);

            Console.WriteLine("**");
            Console.WriteLine($"Результат: z = {result}");
            Console.WriteLine("**");

            Console.ReadKey();
        }
    }
}