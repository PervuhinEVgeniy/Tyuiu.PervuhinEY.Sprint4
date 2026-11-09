using Tyuiu.PervuhinEY.Sprint4.Task0.V30.Lib;
namespace Tyuiu.PervuhinEY.Sprint4.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrE()
        {
            DataService ds = new DataService();
            int[] numsArrey = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int Res = ds.GetSumEvenArrEl(numsArrey);
            int Wait = 30;
            Assert.AreEqual(Res, Wait);

        }
    }
}
