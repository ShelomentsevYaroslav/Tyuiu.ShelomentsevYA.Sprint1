using Tyuiu.ShelomentsevYA.Sprint1.Task1.V16.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint1.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            DataService ds = new DataService();
            double a = 1.0;
            double x = 2.0;
            double y = 3.0;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(16,res);
        }
    }
}
