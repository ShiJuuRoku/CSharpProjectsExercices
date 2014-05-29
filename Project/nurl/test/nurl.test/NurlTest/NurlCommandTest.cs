using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nurl.library;
using nurl.library.Interface;

namespace nurl.test.NurlTest
{
    [TestClass]
    public class NurlCommandTest
    {
        INurlCommand cmd = new NurlCommand();

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ParseTestNullException()
        {
            cmd.Parse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseTestArgumentExceptionEmpty()
        {
            string[] args = {};
            cmd.Parse(args);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseTestArgumentException()
        {
            string[] args = { "command" };
            cmd.Parse(args);
        }
    }
}
