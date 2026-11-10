using Tyuiu.PervuhinEY.Sprint4.Task5.V4.Lib;
namespace Tyuiu.PervuhinEY.Sprint4.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mat = new int[5, 5] { { -6, 6, 5, 3, 3 }, { 5, 7, 4, 6, -4 }, { 1, 2, 4, 1, -5 }, { 1, -7, 2, 5, 7 }, { 4, 2, 6, 5, -6 } };
            int wait = 20;
            int res = ds.Calculate(mat);
            Assert.AreEqual(res, wait);
        }
    }
}
