using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MolodchikovEE.Sprint2.Task6.V5.Lib
{
    public class DataService : ISprint2Task6V5
    {
        public string FindCardValue(int value)
        {
            string result;

            switch (value) 
            {
                case 6: return result = "шестерка";
                case 7: return result = "семерка";
                case 8: return result = "восьмерка";
                case 9: return result = "девятка";
                case 10: return result = "десятка";
                case 11: return result = "валет";
                case 12: return result = "дама";
                case 13: return result = "король";
                case 14: return result = "туз";
                default: throw new ArgumentException("Число должно быть от 6 до 14");
            }
        }
    }
}
