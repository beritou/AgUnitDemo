using Microsoft.Silverlight.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SilverlightDemo.Test.Tests
{
    [TestClass]
    public class WhenAddingAsyncronously : SilverlightTest
    {
        [TestMethod]
        [Asynchronous]
        public void SumOfOnePlusOneIsTwo()
        {
            var calc = new AsyncCalculator();
            const int expectedSum = 2;
            int actualSum = 0;
            
            calc.AsyncronousAddCompleted += sum =>
            {
                actualSum = sum;
            };
            EnqueueCallback(() =>
            {
                calc.AddAsyncronously(1, 1);
                Assert.AreEqual(expectedSum, actualSum);
            });
            EnqueueTestComplete();
        }
    }
}