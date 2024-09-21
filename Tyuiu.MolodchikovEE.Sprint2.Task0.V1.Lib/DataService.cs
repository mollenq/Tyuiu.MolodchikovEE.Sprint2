
using tyuiu.cources.programming.interfaces.Sprint2;



namespace Tyuiu.MolodchikovEE.Sprint2.Task0.V1.Lib
{
    public class DataService : ISprint2Task0V1
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x - 111 == y;
            res[1] = x - 111 != y;
            res[2] = x - 150 < y;
            res[3] = x - 150 > y;
            res[4] = x - 150 <= y;
            res[5] = x - 150 >= y;

            return res;
        }
    }
}





// x = 233

// y=  122


//  true, fal se, tr ue, false, tr ue, false