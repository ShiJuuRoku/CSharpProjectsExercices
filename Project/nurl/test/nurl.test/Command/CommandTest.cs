using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nurl.library;

namespace nurl.test.Command
{
    [TestClass]
    public class CommandTest
    {
        INurlCommand cmd = new NurlCommand();

        [TestMethod]
        public void TestMethod1()
        {
            cmd.Parse(new String[]{"--avg"});
        }
    }
}
