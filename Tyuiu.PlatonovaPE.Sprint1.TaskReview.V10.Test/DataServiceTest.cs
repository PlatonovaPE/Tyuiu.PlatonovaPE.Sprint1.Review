using Tyuiu.PlatonovaPE.Sprint1.TaskReview.V10.Lib;
namespace Tyuiu.PlatonovaPE.Sprint1.TaskReview.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = -13.142;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}