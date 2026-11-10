using Tyuiu.PervuhinEY.Sprint4.Task2.V11.Lib;
namespace Tyuiu.PervuhinEY.Sprint4.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int wait = 30;
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(res,wait);

        }
    }
}
