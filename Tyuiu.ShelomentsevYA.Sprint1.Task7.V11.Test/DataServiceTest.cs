using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShelomentsevYA.Sprint1.Task7.V11.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint1.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            
            double x = 1.0;
            double y = 2.0;

            double result = ds.Calculate(x, y);

            
            double expected = 0.751;

            Assert.AreEqual(expected, result);
        }
    }
}
