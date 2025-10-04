using Tyuiu.ShelomentsevYA.Sprint1.Task0.V16.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint1.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(res, -7);
        }
    }
}
