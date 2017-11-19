using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GiuaKi;
namespace TestCal
{
    [TestClass]
    public class UnitTest1
    {
        public Calculation cal;
        [TestInitialize]
        public void SetUp()
        {
            this.cal = new Calculation(10, 5);
        }

        [TestMethod]
        public void TestMulOperator()
        {
            Assert.AreEqual(cal.Execute(), 50);
        }
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
 @".\Data.csv", "Data#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());
            Calculation c = new Calculation(a, b);
            int actual = c.Execute();
            Assert.AreEqual(expected, actual);

        }

    }
}
