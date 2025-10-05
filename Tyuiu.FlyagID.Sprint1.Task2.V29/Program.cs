using Tyuiu.FlyagID.Sprint1.Task2.V29.Lib;
namespace Tyuiu.FlyagID.Sprint1.Task2.V29
{
    class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("*************************************************************************");
        Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                        ");
        Console.WriteLine("*************************************************************************");

        int x;

        Console.WriteLine("Введите время в секундах");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
        Console.WriteLine("*************************************************************************");

        Console.WriteLine("Время в минутах = " + ds.ConvertSecondsToHours(x));

        Console.ReadLine();
    }
}
}