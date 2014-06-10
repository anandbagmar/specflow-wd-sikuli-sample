using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace google.test
{
    [TestClass]
    public class GoogleSearchTest
    {
        [TestMethod]
        public void SearchForBlog()
        {
            Console.WriteLine("Search for blog test");
            Thread.Sleep(5000);
            Console.WriteLine("After sleep");
            Assert.IsTrue(false, "failing test");
        }
    }
}
