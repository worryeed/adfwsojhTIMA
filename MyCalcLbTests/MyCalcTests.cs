using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyCalcLbTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            //arrange
            int x = 10;
            int y = 20;
            int expected = 30;
            //act
            MyCalcLb c = new MyCalc();
            int actual = c.Sum(x, y);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
