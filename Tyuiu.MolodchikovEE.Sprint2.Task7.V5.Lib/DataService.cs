using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MolodchikovEE.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {

            bool result;

            if (x >= -1 && x <= 1 && y >= Math.Pow(x, 2) && y <= Math.Exp(x) && y <= Math.Exp(-x))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result ;
        }
    }
}
