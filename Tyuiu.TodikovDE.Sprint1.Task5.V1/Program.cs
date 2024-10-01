using Tyuiu.TodikovDE.Sprint1.Task5.V1.Lib;
namespace Tyuiu.TodikovDE.Sprint1.Task5.V1
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
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #1                                                             *");
            Console.WriteLine("* Выполнил: Тодиков Даниил Эдуардович | ИСТНб-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");


            Console.WriteLine("Введите значение X1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите значение X2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            int res = Convert.ToInt32(ds.DistanceBetweenDots(x1, y1, x2, y2));
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}