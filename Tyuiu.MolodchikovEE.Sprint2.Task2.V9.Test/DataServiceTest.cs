using Tyuiu.MolodchikovEE.Sprint2.Task2.V9.Lib;


namespace Tyuiu.MolodchikovEE.Sprint2.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 10;
            int y = 5;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res); 
        }
    }
}