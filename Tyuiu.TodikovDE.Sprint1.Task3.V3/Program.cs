using Tyuiu.TodikovDE.Sprint1.Task3.V3.Lib;
namespace Tyuiu.TodikovDE.Sprint1.Task3.V3
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
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #3                                                             *");
            Console.WriteLine("* Выполнил: Тодиков Даниил Эдуардович | ИСТНб-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            double x = 9;
            double y = 7.5;
            double z = 5;
            Console.WriteLine("Длина параллелепипеда X = " + x);
            Console.WriteLine("Ширина параллелепипеда Y = " + y);
            Console.WriteLine("Высота параллелепипеда Z = " +z);


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Объем параллелепипеда = " + Math.Round(ds.ParallelepipedVolume(x, y, z),3));
            Console.ReadKey();
        }
    }
}