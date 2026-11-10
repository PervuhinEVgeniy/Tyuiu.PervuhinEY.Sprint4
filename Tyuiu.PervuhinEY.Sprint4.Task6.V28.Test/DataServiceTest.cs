using Tyuiu.PervuhinEY.Sprint4.Task6.V28.Lib;
namespace Tyuiu.PervuhinEY.Sprint4.Task6.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculat()
        {
            DataService ds = new DataService();
            string[] mat = new string[] { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море" };
            string[] mas = new string[] { "Река", "Лужа", "Море" };
            string[] res = ds.Calculate(mas);
            CollectionAssert.AreEqual(mas, res);
        }
    }
}
