using Tyuiu.MolodchikovEE.Sprint2.Task1.V23.Lib;


namespace Tyuiu.MolodchikovEE.Sprint2.Task1.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Молодчиков Е.Е. | ИИПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Молодчиков Егор Евгеньевич | ИИПб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в выражении)*");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность операций  *");
            Console.WriteLine("* не должна нарушаться), а также арифметических выражений, которая вернет *");
            Console.WriteLine("* логическую последовательность(массив): (False, False, False, True, True, True) *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("a = 242");
            int a = 242;
            Console.WriteLine("b = 571");
            int b = 571;
            Console.WriteLine("c = 325");
            int c = 325;
            Console.WriteLine("d = 155");
            int d = 155;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadLine();
        }
    }
}
