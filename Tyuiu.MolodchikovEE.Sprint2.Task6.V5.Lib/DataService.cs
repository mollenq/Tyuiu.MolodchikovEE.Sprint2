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
                case 6: return result = "��������";
                case 7: return result = "�������";
                case 8: return result = "���������";
                case 9: return result = "�������";
                case 10: return result = "�������";
                case 11: return result = "�����";
                case 12: return result = "����";
                case 13: return result = "������";
                case 14: return result = "���";
                default: throw new ArgumentException("����� ������ ���� �� 6 �� 14");
            }
        }
    }
}
