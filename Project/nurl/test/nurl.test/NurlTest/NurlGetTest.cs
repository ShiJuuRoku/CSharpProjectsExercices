using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nurl.library;
using System.IO;
using System.Net;

namespace nurl.test.NurlTest
{
    [TestClass]
    public class NurlGetTest
    {
        INurl nurl = new Nurl();
        string url = "B:/Etudes/ESGI/4AL2/Langage C#/CSharpProjectsExercices/Project/nurl/test/nurl.test/Pages/page1.html";
        [TestMethod]
        public void GetSuccessful()
        {
            Assert.AreEqual("<h1>Hello World</h1>", nurl.Get((url)));
        }

        [TestMethod]
        public void GetFailed()
        {
            Assert.AreNotEqual("Hello World</h1>", nurl.Get((url)));
        }

        [TestMethod]
        [ExpectedException(typeof(WebException))]
        public void GetFailedWebExcetion()
        {
            nurl.Get("http://www.failedurl.fr");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetFailedNullExcetion()
        {
            nurl.Get(null);
        }
    }

    [TestClass]
    public class NurlSaveTest
    {
        INurl nurl = new Nurl();
        string uri = "B:/Etudes/ESGI/4AL2/Langage C#/CSharpProjectsExercices/Project/nurl/test/nurl.test/Pages/page1.html";
        string path = "content.txt";
        [TestMethod]
        public void SaveSuccessful()
        {
            nurl.Save(uri, path);
            var expected = "<h1>Hello World</h1>";
            using(var file = File.OpenText(path))
            {
                var content = file.ReadToEnd();
                Assert.AreEqual(expected, content);
            }
        }

        [TestMethod]
        public void SaveFailed()
        {
            nurl.Save(uri, path);
            var notExpected = "<h1>GoodB Bye</h1>";
            using (var file = File.OpenText(path))
            {
                var content = file.ReadToEnd();
                Assert.AreNotEqual(notExpected, content);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(WebException))]
        public void GetFailedWebExcetion()
        {
            nurl.Save("http://www.failedurl.fr", path);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetFailedNullExcetionUri()
        {
            nurl.Save(null, path);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetFailedNullExcetionPath()
        {
            nurl.Save(uri, null);
        }

    }

}
