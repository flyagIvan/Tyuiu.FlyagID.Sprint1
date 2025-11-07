using System;
using Tyuiu.FlyagID.Sprint1.Task5.V4.Lib;

namespace Tyuiu.FlyagID.Sprint1.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Фляг И.Д. | ИСПб-25-1";
            Console.WriteLine("**");
            Console.WriteLine("* Спринт #1                                                ");
            Console.WriteLine(" Тема: Операторы составного присваивания                  ");
            Console.WriteLine(" Задание #5                                               ");
            Console.WriteLine(" Вариант #4                                               ");
            Console.WriteLine(" Выполнил: Фляг И.Д. | ИСПб-25-1                          ");
            Console.WriteLine("**");
            Console.WriteLine(" УСЛОВИЕ:                                                 ");
            Console.WriteLine(" Идёт k-я секунда суток. Определить, сколько полных часов ");
            Console.WriteLine(" прошло к этому моменту.                                  ");
            Console.WriteLine(" Например: если k = 13257, то h = 3.                      *");
            Console.WriteLine("**");

            Console.Write("Введите количество секунд (k): ");
            int k = Convert.ToInt32(Console.ReadLine());

            int result = ds.SecondsToHours(k);

            Console.WriteLine("**");
            Console.WriteLine($"Полных часов прошло: {result}");
            Console.WriteLine("**");

            Console.ReadKey();
        }
    }
}
