using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello world";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                CycleTask.Program.Main();
                var rezult = sw.ToString().Trim();
                Assert.AreEqual(Expected, rezult);
            }
        }
    }
}
