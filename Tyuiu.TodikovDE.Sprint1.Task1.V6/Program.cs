using Tyuiu.TodikovDE.Sprint1.Task1.V6.Lib;
namespace Tyuiu.TodikovDE.Sprint1.Task1.V6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Тодиков Д. Э. | ИСТНб-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спритн #1                                                              *");
            Console.WriteLine("* Тема: Создания итогого решения по спринту                              *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнил: Тодиков Даниил Эдуардович | ИСТНб-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Условие:                                                               *");
            Console.WriteLine("* Написать консольную программу, которая вычисляет выражение (x+y)/(3*y) *");
            Console.WriteLine("* и печатает результат на экране                                         *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*     (x+y)/(3*y)                                                        *");


            double x, y;
            Console.WriteLine("Введите значие Х:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значие Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}