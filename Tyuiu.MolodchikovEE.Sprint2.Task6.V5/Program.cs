using Tyuiu.MolodchikovEE.Sprint2.Task6.V5.Lib;
namespace Tyuiu.MolodchikovEE.Sprint2.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Получение результата из switch                                          *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #5                                                            *");
            Console.WriteLine("* Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
			Console.WriteLine("*Игральным картам условно присвоены следующие порядковые номера в зависимо*");
			Console.WriteLine("*ости от их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу»*");
			Console.WriteLine("*» — 14. Порядковые номера остальных карт соответствуют их названиям («шес*");
			Console.WriteLine("*стерка», «девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) оп*");
			Console.WriteLine("*пределить достоинство соответствующей карты.                             *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int x = 6;

            string result = ds.FindCardValue(x);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}