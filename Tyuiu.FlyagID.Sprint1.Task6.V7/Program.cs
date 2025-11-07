using System;
using Tyuiu.FlyagID.Sprint1.Task6.V7.Lib;

namespace Tyuiu.FlyagID.Sprint1.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Фляг И.Д. | ИСПб-25-1";
            Console.WriteLine("**");
            Console.WriteLine("* Спринт #1                                                ");
            Console.WriteLine(" Тема: Работа со строками                                 ");
            Console.WriteLine(" Задание #6                                               ");
            Console.WriteLine(" Вариант #7                                               ");
            Console.WriteLine(" Выполнил: Фляг И.Д. | ИСПб-25-1                          ");
            Console.WriteLine("**");
            Console.WriteLine(" УСЛОВИЕ:                                                 ");
            Console.WriteLine(" Пользователь вводит текст. Напечатать все слова, удалив  ");
            Console.WriteLine(" из них последнюю букву.                                  *");
            Console.WriteLine("**");

            Console.Write("Введите текст: ");
            string input = Console.ReadLine();

            string result = ds.DeleteLastLetter(input);

            Console.WriteLine("**");
            Console.WriteLine("Результат:");
            Console.WriteLine(result);
            Console.WriteLine("**");

            Console.ReadKey();
        }
    }
}