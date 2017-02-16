namespace TaksManager.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Diagnostics;
    using System.IO;

    [TestClass]
    public class Test
    {
        [TestCleanup]
        public void TestsCleanup()
        {
            sw.WriteLine("TestsCleanup()");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            sw.WriteLine("TestInitialize()");
        }

        StreamWriter sw = new StreamWriter("test.txt");
        [ClassInitialize]
        public void ClassInitialize(TestContext testContext)
        {
            sw.WriteLine("ClassInitialize()");
        }

        [ClassCleanup]
        public void ClassCleanup()
        {
            sw.WriteLine("ClassCleanup()");
        }

        [TestMethod]
        public void TestMethod()
        {
            sw.WriteLine("TestMethod()");
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            sw.WriteLine("TestMethod2()");
        }
        
        [TestMethod]
        public void TestMethod3()
        {
            sw.WriteLine("TestMethod3()");
        }
    }
}
