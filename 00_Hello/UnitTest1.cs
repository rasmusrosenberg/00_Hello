using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Hello
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHello()
        {
            Assert.AreEqual("Hello", Functions.Hello());
        }
        [TestMethod]
        public void TestHelloFred()
        {
            Assert.AreEqual("Hello, Fred", Functions.Hello("Fred"));
        }
    }

    internal class Functions
    {
        public static String Hello(string name = "")
        {
            if (name == "")
            {
                return "Hello";
            } else
            {
                return "Hello, " + name;
            }
            
        }
    }
}
