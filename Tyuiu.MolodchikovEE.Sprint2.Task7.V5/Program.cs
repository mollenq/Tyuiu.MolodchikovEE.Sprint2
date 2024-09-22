using Tyuiu.MolodchikovEE.Sprint2.Task7.V5.Lib;
namespace Tyuiu.MolodchikovEE.Sprint2.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #5                                                            *");
            Console.WriteLine("* Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу на C#, которая запрашивает исходные данные (вещественн*");
            Console.WriteLine("*ные значения) и вычисляет, находится ли точка с координатами X,Y в заштри*");
            Console.WriteLine("*ихованной области.                                                       *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.Write("Введите координату X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            var result = ds.CheckDotInShadedArea(x,y);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}