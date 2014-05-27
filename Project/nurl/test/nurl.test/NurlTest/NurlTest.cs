using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nurl.library;

namespace nurl.test.NurlTest
{
    [TestClass]
    public class NurlGetTest
    {
        INurl nurl = new Nurl();

        [TestMethod]
        public void GetSuccessful()
        {
            var url = "B:/Etudes/ESGI/4AL2/Langage C#/CSharpProjectsExercices/Project/nurl/test/nurl.test/Pages/page1.html";
            Assert.AreEqual("<h1>Hello World</h1>", nurl.Get((url)));
        }

        [TestMethod]
        public void GetFailed()
        {
            var url = "B:/Etudes/ESGI/4AL2/Langage C#/CSharpProjectsExercices/Project/nurl/test/nurl.test/Pages/page1.html";
            Assert.AreNotEqual("Hello World</h1>", nurl.Get((url)));
        }
    }
}
