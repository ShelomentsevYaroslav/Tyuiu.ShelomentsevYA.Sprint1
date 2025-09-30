using Tyuiu.ShelomentsevYA.Sprint1.Task2.V6.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint1.Task1.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1789;
            var res = ds.ConvertMToKm(x);
            Assert.AreEqual(1.789, res);
        }
    }
}