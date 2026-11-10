using System.Net.Http.Headers;
using Tyuiu.PervuhinEY.Sprint4.Task7.V30.Lib;
namespace Tyuiu.PervuhinEY.Sprint4.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 5;
            int m = 3;

            DataService ds = new DataService();
            int[,] mtrx = new int[5, 3];
            string str = "684259137159648";
            int res = ds.Calculate(n,m,str);
            int wait = 73728;
            Assert.AreEqual(wait, res);

        }
    }
}
