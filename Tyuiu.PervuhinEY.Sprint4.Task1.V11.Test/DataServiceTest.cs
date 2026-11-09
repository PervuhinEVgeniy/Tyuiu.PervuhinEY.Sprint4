using Tyuiu.PervuhinEY.Sprint4.Task1.V11.Lib;
namespace Tyuiu.PervuhinEY.Sprint4.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArrey = { 2, 6, 5, 5, 1, 5, 6, 5, 5, 5, 1, 5, 3, 6, 6, 1, 6};
            int Res = ds.Calculate(numsArrey);
            int Wait = 30;
            Assert.AreEqual(Res, Wait);
        }
    }
}
