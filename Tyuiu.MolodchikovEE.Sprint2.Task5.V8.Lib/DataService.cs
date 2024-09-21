using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MolodchikovEE.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            
            m -= 1;
            string result = m+".0"+n;
            return result;
            
        }
    }
}