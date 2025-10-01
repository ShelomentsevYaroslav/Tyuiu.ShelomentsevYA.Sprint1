using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.ShelomentsevYA.Sprint1.Task3.V8.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint1.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double startAmount = 2500;
            double percent = 20;
            double timeDays = 30;
            double res = ds.IncomeAmount(startAmount, percent, timeDays);

            Assert.AreEqual(41.096,res);

        }
    }
}
