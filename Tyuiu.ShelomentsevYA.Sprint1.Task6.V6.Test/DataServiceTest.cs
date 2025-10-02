using Tyuiu.ShelomentsevYA.Sprint1.Task6.V6.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint1.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            
            DataService ds = new DataService();
            string text = "Привет мир это тест";


            
            string res = ds.DeleteFirstLetter(text);

            
            Assert.AreEqual("ривет ир то ест", res);
        }
    }
}
