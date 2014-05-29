using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nurl.library.Interface;
using nurl.library;
using System.Linq;

namespace nurl.test.NurlTest
{
    [TestClass]
    public class NurlTestTest
    {
        INurl nurl = new Nurl();
        string uri = "http://google.fr";

        [TestMethod]
        public void TestNurlTestSuccessfull()
        {
            int n = 5;
            Assert.AreEqual(n, nurl.Test(uri, n).Count());
        }

        [TestMethod]
        public void TestNurlTestFailed()
        {
            Assert.AreNotEqual(0, nurl.Test(uri, 5).Count());
        }
    }
}
