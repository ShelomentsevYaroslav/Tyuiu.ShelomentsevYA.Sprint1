using Tyuiu.ShelomentsevYA.Sprint1.Task5.V4.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()

        {
            DataService ds = new DataService();
            int x = 13257;
            int res = ds.SecondsToHours(x);
            Assert.AreEqual(3, res);
        }
    }
}
